using SmallNetCore.Models.Enums;
using SqlSugar;
using System;
namespace SmallNetCore.Models.DBModels.FirstTestDb
{


    [Tenant(MySqlConnEnum.FisrtTestDb)]
    public class Worker
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
