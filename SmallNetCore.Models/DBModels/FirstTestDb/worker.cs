using SmallNetCore.Models.Enums;
using SqlSugar;
using System;
namespace SmallNetCore.Models.DBModels.FirstTestDb
{


    [Tenant(MySqlConnEnum.FisrtTestDb)]
    [SugarTable("workers")]
    public class Worker
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }
        public string name { get; set; }
        public DateTime? created_at { get; set; }
    }
}
