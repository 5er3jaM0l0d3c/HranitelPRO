using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace qwer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        public IWorker Worker { get; set; }
        public WorkerController(IWorker worker) {  Worker = worker; }

        [HttpGet(nameof(GetWorkers))]
        public List<Worker> GetWorkers()
        {
            return Worker.GetWorkers();
        }

        [HttpPost(nameof(AddWorker))]
        public void AddWorker(Worker worker)
        {
            Worker.AddWorker(worker);
        }

        [HttpDelete(nameof(DeleteWorkers))]
        public void DeleteWorkers(int code) 
        {
            Worker.DeleteWorker(code);
        }
    }
}
