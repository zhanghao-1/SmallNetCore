using SmallNetCore.IRepository.FirstTestDb;
using SmallNetCore.Models.DBModels.FirstTestDb;
using SmallNetCore.Repository.Base;

namespace SmallNetCore.Repository.FirstTestDb
{
    public class WorkerRepository : BaseRepository<Worker>, IWorkerRepository
    {

    }
} 