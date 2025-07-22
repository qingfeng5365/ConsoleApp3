using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    [SugarTable("user")]
    public partial class User
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        public string? Name { get; set; }
        public int? Age { get; set; }
    }
}
