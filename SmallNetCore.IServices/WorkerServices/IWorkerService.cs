using SmallNetCore.Models.DBModels.FirstTestDb;
using SmallNetCore.Models.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallNetCore.IServices.WorkerServices
{
    public interface IWorkerService
    {
        /// <summary>
        /// Add a new worker
        /// </summary>
        /// <param name="worker">Worker entity</param>
        /// <returns>Worker ID</returns>
        BaseResponse<int> AddWorker(Worker worker);
        
        /// <summary>
        /// Update worker information
        /// </summary>
        /// <param name="worker">Worker entity</param>
        /// <returns>Success status</returns>
        BaseResponse<bool> UpdateWorker(Worker worker);
        
        /// <summary>
        /// Delete worker by ID
        /// </summary>
        /// <param name="id">Worker ID</param>
        /// <returns>Success status</returns>
        BaseResponse<bool> DeleteWorker(int id);
        
        /// <summary>
        /// Get worker by ID
        /// </summary>
        /// <param name="id">Worker ID</param>
        /// <returns>Worker entity</returns>
        BaseResponse<Worker> GetWorker(int id);
        
        /// <summary>
        /// Get all workers
        /// </summary>
        /// <returns>List of workers</returns>
        BaseResponse<List<Worker>> GetAllWorkers();
    }
} 