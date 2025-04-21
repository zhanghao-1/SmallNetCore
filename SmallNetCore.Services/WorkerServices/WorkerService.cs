using SmallNetCore.Common.Convets;
using SmallNetCore.IRepository.FirstTestDb;
using SmallNetCore.IServices.Base;
using SmallNetCore.IServices.WorkerServices;
using SmallNetCore.Models.DBModels.FirstTestDb;
using SmallNetCore.Models.ViewModels.Base;
using static SmallNetCore.Models.ViewModels.Base.CommonResponse;

namespace SmallNetCore.Services.WorkerServices
{
    public class WorkerService : IWorkerService
    {
        private readonly IWorkerRepository _workerRepository;
        private readonly IClaimsAccessor _claimsAccessor;

        public WorkerService(IClaimsAccessor claimsAccessor, IWorkerRepository workerRepository)
        {
            _claimsAccessor = claimsAccessor;
            _workerRepository = workerRepository;
        }

        /// <summary>
        /// Add a new worker
        /// </summary>
        /// <param name="worker">Worker entity</param>
        /// <returns>Worker ID</returns>
        public BaseResponse<int> AddWorker(Worker worker)
        {
            if (worker.CreatedAt == null)
                worker.CreatedAt = DateTime.Now;
                
            var result = _workerRepository.InsertReturnIdentity(worker);
            return GetOK(result);
        }

        /// <summary>
        /// Update worker information
        /// </summary>
        /// <param name="worker">Worker entity</param>
        /// <returns>Success status</returns>
        public BaseResponse<bool> UpdateWorker(Worker worker)
        {
            var result = _workerRepository.Update(worker);
            return GetOK(result);
        }

        /// <summary>
        /// Delete worker by ID
        /// </summary>
        /// <param name="id">Worker ID</param>
        /// <returns>Success status</returns>
        public BaseResponse<bool> DeleteWorker(int id)
        {
            var result = _workerRepository.DeleteById(id);
            return GetOK(result);
        }

        /// <summary>
        /// Get worker by ID
        /// </summary>
        /// <param name="id">Worker ID</param>
        /// <returns>Worker entity</returns>
        public BaseResponse<Worker> GetWorker(int id)
        {
            var worker = _workerRepository.GetById(id);
            return GetOK(worker);
        }

        /// <summary>
        /// Get all workers
        /// </summary>
        /// <returns>List of workers</returns>
        public BaseResponse<List<Worker>> GetAllWorkers()
        {
            var workers = _workerRepository.GetList();
            return GetOK(workers);
        }
    }
} 