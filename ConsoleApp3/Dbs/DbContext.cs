using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

public class DbContext
{
    public SqlSugarClient Db;

    public DbContext()
    {
        Db = new SqlSugarClient(new ConnectionConfig()
        {
            ConnectionString = "Server=;Database=cwbaseGS70;User Id=sa;Password=;Encrypt=True;TrustServerCertificate=True;",
            DbType = DbType.SqlServer,
            IsAutoCloseConnection = true,
            InitKeyType = InitKeyType.Attribute // 使用实体特性配置表结构
        });

        // 打印执行的 SQL
        Db.Aop.OnLogExecuting = (sql, pars) =>
        {
            Console.WriteLine(sql);
        };
    }
}
