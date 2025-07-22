using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Dbs
{
    internal class TargetDbContext
    {
        public SqlSugarClient Db;
        public TargetDbContext()
        {
            Db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "Server=;Database=cwbaseGS70;User Id=sa;Password=;Encrypt=True;TrustServerCertificate=True;",
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            });
        }
    }
}
