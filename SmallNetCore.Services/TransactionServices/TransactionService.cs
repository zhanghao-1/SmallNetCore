using SmallNetCore.Common.Convets;
using SmallNetCore.IRepository.FirstTestDb;
using SmallNetCore.IServices.Base;
using SmallNetCore.IServices.TransactionServices;
using SmallNetCore.Models.DBModels.FirstTestDb;
using SmallNetCore.Models.ViewModels.Base;
using static SmallNetCore.Models.ViewModels.Base.CommonResponse;

namespace SmallNetCore.Services.TransactionServices
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IClaimsAccessor _claimsAccessor;

        public TransactionService(IClaimsAccessor claimsAccessor, ITransactionRepository transactionRepository)
        {
            _claimsAccessor = claimsAccessor;
            _transactionRepository = transactionRepository;
        }

        /// <summary>
        /// Add a new transaction
        /// </summary>
        /// <param name="transaction">Transaction entity</param>
        /// <returns>Transaction ID</returns>
        public BaseResponse<int> AddTransaction(Transaction transaction)
        {
            if (transaction.CreatedAt == null)
                transaction.CreatedAt = DateTime.Now;
            
            if (transaction.IsActive == null)
                transaction.IsActive = true;
                
            var result = _transactionRepository.InsertReturnIdentity(transaction);
            return GetOK(result);
        }

        /// <summary>
        /// Update transaction information
        /// </summary>
        /// <param name="transaction">Transaction entity</param>
        /// <returns>Success status</returns>
        public BaseResponse<bool> UpdateTransaction(Transaction transaction)
        {
            var result = _transactionRepository.Update(transaction);
            return GetOK(result);
        }

        /// <summary>
        /// Delete transaction by ID
        /// </summary>
        /// <param name="id">Transaction ID</param>
        /// <returns>Success status</returns>
        public BaseResponse<bool> DeleteTransaction(int id)
        {
            var result = _transactionRepository.DeleteById(id);
            return GetOK(result);
        }

        /// <summary>
        /// Get transaction by ID
        /// </summary>
        /// <param name="id">Transaction ID</param>
        /// <returns>Transaction entity</returns>
        public BaseResponse<Transaction> GetTransaction(int id)
        {
            var transaction = _transactionRepository.GetById(id);

            return GetOK(transaction);

        }

        /// <summary>
        /// Get all transactions
        /// </summary>
        /// <returns>List of transactions</returns>
        public BaseResponse<List<Transaction>> GetAllTransactions()
        {
            var transactions = _transactionRepository.GetList();
            return GetOK(transactions);

        }
        
        /// <summary>
        /// Get transactions by worker ID
        /// </summary>
        /// <param name="workerId">Worker ID</param>
        /// <returns>List of transactions</returns>
        public BaseResponse<List<Transaction>> GetTransactionsByWorkerId(int workerId)
        {
            var transactions = _transactionRepository.GetList(t => t.WorkerId == workerId);
            return GetOK(transactions);
        }
        
        /// <summary>
        /// Get transactions by type (income or expense)
        /// </summary>
        /// <param name="type">Transaction type</param>
        /// <returns>List of transactions</returns>
        public BaseResponse<List<Transaction>> GetTransactionsByType(string type)
        {
            var transactions = _transactionRepository.GetList(t => t.Type == type);
            return GetOK(transactions);
        }
    }
} 