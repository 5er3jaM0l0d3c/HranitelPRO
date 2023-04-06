using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IWorker
    {
        List<Worker> GetWorkers();
        void AddWorker(Worker worker);
        void DeleteWorker(int code);
    }
}
