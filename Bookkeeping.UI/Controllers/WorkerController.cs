using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmallNetCore.IServices.WorkerServices;
using SmallNetCore.Models.DBModels.FirstTestDb;
using SmallNetCore.Models.ViewModels.Base;

namespace SmallNetCore.UI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    //[Authorize]
    public class WorkerController : ControllerBase
    {
        private readonly IWorkerService _workerService;

        public WorkerController(IWorkerService workerService)
        {
            _workerService = workerService;
        }

        /// <summary>
        /// Add a new worker
        /// </summary>
        /// <param name="worker">Worker entity</param>
        /// <returns>Worker ID</returns>
        [HttpPost]
        public BaseResponse<int> AddWorker(Worker worker)
        {
            return _workerService.AddWorker(worker);
        }

        /// <summary>
        /// Update worker information
        /// </summary>
        /// <param name="worker">Worker entity</param>
        /// <returns>Success status</returns>
        [HttpPut]
        public BaseResponse<bool> UpdateWorker(Worker worker)
        {
            return _workerService.UpdateWorker(worker);
        }

        /// <summary>
        /// Delete worker by ID
        /// </summary>
        /// <param name="id">Worker ID</param>
        /// <returns>Success status</returns>
        [HttpDelete]
        public BaseResponse<bool> DeleteWorker(int id)
        {
            return _workerService.DeleteWorker(id);
        }

        /// <summary>
        /// Get worker by ID
        /// </summary>
        /// <param name="id">Worker ID</param>
        /// <returns>Worker entity</returns>
        [HttpGet]
        public BaseResponse<Worker> GetWorker(int id)
        {
            return _workerService.GetWorker(id);
        }

        /// <summary>
        /// Get all workers
        /// </summary>
        /// <returns>List of workers</returns>
        [HttpGet]
        public BaseResponse<List<Worker>> GetAllWorkers()
        {
            return _workerService.GetAllWorkers();
        }
    }
} 