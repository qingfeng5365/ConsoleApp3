using ConsoleApp3;
using ConsoleApp3.Dbs;
using ConsoleApp3.Models;
using SqlSugar;


internal class Program
{
    static async Task Main(string[] args)
    {

        DateTime startDate = DateTime.ParseExact("20250529", "yyyyMMdd", null);
        DateTime endDate = DateTime.Today;
        int pageSize = 100;


        var tasks = new List<Task>
        {
            //SafeRun(() => SyncUser(), "SyncUser"),
            SafeRun(() => SyncInvBalRealAccount(pageSize), "InvBalRealAccount"),
            //SafeRun(() => SyncGoodsMovement(startDate, endDate,pageSize), "GoodsMovement"),
            SafeRun(() => SyncGoodsMovementItem(startDate, endDate,pageSize), "GoodsMovementItem"),
            //SafeRun(() => SyncGoodsMovementAss(startDate, endDate,pageSize), "GoodsMovementAss"),
            //Task.Run(() => SyncGoodsMovementAss(startDate, endDate, pageSize)),
            //Task.Run(() => SyncGoodsMovementItem(startDate, endDate, pageSize)),
            //Task.Run(() => SyncGoodsMovement(startDate, endDate)),
            //Task.Run(() => SyncInvBalRealAccount(pageSize))
        };
        await Task.WhenAll(tasks);
        Console.WriteLine("所有任务完成");
    }

    static async Task SafeRun(Func<Task> func, string tag)
    {
        try
        {
            await func();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[{tag}] 同步失败：{ex.Message}");
        }
    }

    static async Task SyncUser()
    {
        var db = new DbContext().Db;
        var users = await db.Queryable<User>().ToListAsync();
        foreach (var u in users)
        {
            Console.WriteLine($"ID: {u.Id}, 姓名: {u.Name}, 年龄: {u.Age}");
        }
    }

    static async Task SyncInvBalRealAccount(int pageSize)
    {
        var sourceDb = new SourceDbContext().Db;
        var targetDb = new TargetDbContext().Db;

        int pageIndex = 1;

        while (true)
        {
            var pageData = await sourceDb.Queryable<InvBalRealAccount>()
                .Where(x => SqlFunc.ToInt32(x.FiscalYear) * 100 + SqlFunc.ToInt32(x.FiscalPeriod) >= 202505)
                .OrderBy(x => x.ID) 
                .ToPageListAsync(pageIndex, pageSize);

            if (pageData.Count == 0)
                break;

            await targetDb.Storageable(pageData).ExecuteCommandAsync();
            Console.WriteLine($"[InvBalRealAccount] 同步分页 {pageIndex}");

            pageIndex++;
        }
    }

    static async Task SyncGoodsMovement(DateTime start, DateTime end, int pageSize)
    {
        var sourceDb = new SourceDbContext().Db;
        var targetDb = new TargetDbContext().Db;

        for (DateTime date = start; date <= end; date = date.AddDays(1))
        {
            string dateStr = date.ToString("yyyyMMdd");
            int pageIndex = 1;

            while (true)
            {
                var pageData = await sourceDb.Queryable<GoodsMovement>()
                    .Where(x => x.CreateDate == dateStr)
                    .OrderBy(x => x.GoodsMovementID) 
                    .ToPageListAsync(pageIndex, pageSize);

                if (pageData.Count == 0)
                    break;

                Console.WriteLine($"[GoodsMovement] 同步日期 {dateStr} 第 {pageIndex} 页，记录数：{pageData.Count}");

                await targetDb.Storageable(pageData).ExecuteCommandAsync();

                pageIndex++;
            }
        }
    }

    static async Task SyncGoodsMovementItem(DateTime start, DateTime end, int pageSize)
    {
        var sourceDb = new SourceDbContext().Db;
        var targetDb = new TargetDbContext().Db;

        for (DateTime date = start; date <= end; date = date.AddDays(1))
        {
            string dateStr = date.ToString("yyyyMMdd");
            int pageIndex = 0;

            while (true)
            {
                var pageData = await sourceDb.Ado.SqlQueryAsync<GoodsMovementItem>(
                    $@"
                SELECT B.* 
                FROM (
                    SELECT A.GoodsMovementID 
                    FROM LCGS709999.GoodsMovement A 
                    WHERE A.CreateDate = @createDate
                    ORDER BY A.GoodsMovementID
                    OFFSET @offset ROWS FETCH NEXT @pageSize ROWS ONLY
                ) AS T
                LEFT JOIN LCGS709999.GoodsMovementItem B ON T.GoodsMovementID = B.GoodsMovementID
                ",
                    new
                    {
                        createDate = dateStr,
                        offset = pageIndex * pageSize,
                        pageSize
                    });

                if (pageData.Count == 0)
                    break;

                Console.WriteLine($"[GoodsMovementItem] 同步日期 {dateStr}，第 {pageIndex + 1} 页，记录数：{pageData.Count}");

         
                await targetDb.Storageable(pageData).ExecuteCommandAsync();


                pageIndex++;
            }
        }
    }


    static async Task SyncGoodsMovementAss(DateTime start, DateTime end, int pageSize)
    {
        var sourceDb = new SourceDbContext().Db;
        var targetDb = new TargetDbContext().Db;

        for (DateTime date = start; date <= end; date = date.AddDays(1))
        {
            string dateStr = date.ToString("yyyyMMdd");
            int pageIndex = 0;

            while (true)
            {
                var pageData = await sourceDb.Ado.SqlQueryAsync<GoodsMovementAss>(
                    $@"
                SELECT B.* 
                FROM (
                    SELECT A.GoodsMovementID 
                    FROM LCGS709999.GoodsMovement A 
                    WHERE A.CreateDate = @createDate
                    ORDER BY A.GoodsMovementID
                    OFFSET @offset ROWS FETCH NEXT @pageSize ROWS ONLY
                ) AS T
                LEFT JOIN LCGS709999.GoodsMovementAss B 
                    ON T.GoodsMovementID = B.GoodsMovementID
                WHERE B.GoodsMovementID IS NOT NULL
                ",
                    new
                    {
                        createDate = dateStr,
                        offset = pageIndex * pageSize,
                        pageSize
                    });

                if (pageData.Count == 0)
                    break;

                Console.WriteLine($"[GoodsMovementAss] 同步日期 {dateStr}，第 {pageIndex + 1} 页，记录数：{pageData.Count}");

                await targetDb.Storageable(pageData).ExecuteCommandAsync();

                pageIndex++;
            }
        }
    }


}