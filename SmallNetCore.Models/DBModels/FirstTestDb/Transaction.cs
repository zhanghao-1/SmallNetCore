using SmallNetCore.Models.Enums;
using SqlSugar;
using System;

namespace SmallNetCore.Models.DBModels.FirstTestDb
{
    [Tenant(MySqlConnEnum.FisrtTestDb)]
    [SugarTable("transactions")]
    public class Transaction
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        [SugarColumn(ColumnName = "worker_id")]
        public int WorkerId { get; set; }

        [SugarColumn(ColumnName = "type")]
        public string Type { get; set; }  // 'income' or 'expense'

        [SugarColumn(ColumnName = "amount")]
        public decimal Amount { get; set; }

        [SugarColumn(ColumnName = "remark")]
        public string Remark { get; set; }

        [SugarColumn(ColumnName = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [SugarColumn(ColumnName = "is_active")]
        public bool? IsActive { get; set; }
    }
} 