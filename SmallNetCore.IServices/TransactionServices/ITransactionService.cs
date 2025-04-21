using SmallNetCore.Models.DBModels.FirstTestDb;
using SmallNetCore.Models.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallNetCore.IServices.TransactionServices
{
    public interface ITransactionService
    {
        /// <summary>
        /// Add a new transaction
        /// </summary>
        /// <param name="transaction">Transaction entity</param>
        /// <returns>Transaction ID</returns>
        BaseResponse<int> AddTransaction(Transaction transaction);
        
        /// <summary>
        /// Update transaction information
        /// </summary>
        /// <param name="transaction">Transaction entity</param>
        /// <returns>Success status</returns>
        BaseResponse<bool> UpdateTransaction(Transaction transaction);
        
        /// <summary>
        /// Delete transaction by ID
        /// </summary>
        /// <param name="id">Transaction ID</param>
        /// <returns>Success status</returns>
        BaseResponse<bool> DeleteTransaction(int id);
        
        /// <summary>
        /// Get transaction by ID
        /// </summary>
        /// <param name="id">Transaction ID</param>
        /// <returns>Transaction entity</returns>
        BaseResponse<Transaction> GetTransaction(int id);
        
        /// <summary>
        /// Get all transactions
        /// </summary>
        /// <returns>List of transactions</returns>
        BaseResponse<List<Transaction>> GetAllTransactions();
        
        /// <summary>
        /// Get transactions by worker ID
        /// </summary>
        /// <param name="workerId">Worker ID</param>
        /// <returns>List of transactions</returns>
        BaseResponse<List<Transaction>> GetTransactionsByWorkerId(int workerId);
        
        /// <summary>
        /// Get transactions by type (income or expense)
        /// </summary>
        /// <param name="type">Transaction type</param>
        /// <returns>List of transactions</returns>
        BaseResponse<List<Transaction>> GetTransactionsByType(string type);
    }
} 