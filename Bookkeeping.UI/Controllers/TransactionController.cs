using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmallNetCore.IServices.TransactionServices;
using SmallNetCore.Models.DBModels.FirstTestDb;
using SmallNetCore.Models.ViewModels.Base;

namespace SmallNetCore.UI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    //[Authorize]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }


        /// <summary>
        /// Add a new transaction
        /// </summary>
        /// <param name="transaction">Transaction entity</param>
        /// <returns>Transaction ID</returns>
        [HttpPost]
        public BaseResponse<int> AddTransaction(Transaction transaction)
        {
            return _transactionService.AddTransaction(transaction);
        }


        /// <summary>
        /// Update transaction information
        /// </summary>
        /// <param name="transaction">Transaction entity</param>
        /// <returns>Success status</returns>
        [HttpPut]
        public BaseResponse<bool> UpdateTransaction(Transaction transaction)
        {
            return _transactionService.UpdateTransaction(transaction);
        }

        /// <summary>
        /// Delete transaction by ID
        /// </summary>
        /// <param name="id">Transaction ID</param>
        /// <returns>Success status</returns>
        [HttpDelete]
        public BaseResponse<bool> DeleteTransaction(int id)
        {
            return _transactionService.DeleteTransaction(id);
        }

        /// <summary>
        /// Get transaction by ID
        /// </summary>
        /// <param name="id">Transaction ID</param>
        /// <returns>Transaction entity</returns>
        [HttpGet]
        public BaseResponse<Transaction> GetTransaction(int id)
        {
            return _transactionService.GetTransaction(id);
        }

        /// <summary>
        /// Get all transactions
        /// </summary>
        /// <returns>List of transactions</returns>
        [HttpGet]
        public BaseResponse<List<Transaction>> GetAllTransactions()
        {
            return _transactionService.GetAllTransactions();
        }
        
        /// <summary>
        /// Get transactions by worker ID
        /// </summary>
        /// <param name="workerId">Worker ID</param>
        /// <returns>List of transactions</returns>
        [HttpGet]
        public BaseResponse<List<Transaction>> GetTransactionsByWorkerId(int workerId)
        {
            return _transactionService.GetTransactionsByWorkerId(workerId);
        }
        
        /// <summary>
        /// Get transactions by type (income or expense)
        /// </summary>
        /// <param name="type">Transaction type</param>
        /// <returns>List of transactions</returns>
        [HttpGet]
        public BaseResponse<List<Transaction>> GetTransactionsByType(string type)
        {
            return _transactionService.GetTransactionsByType(type);
        }
    }
} 