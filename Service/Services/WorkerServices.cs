using Entities;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class WorkerServices : IWorker
    {
        public UsersContext Context { get; set; }
        public WorkerServices(UsersContext usersContext) 
        {
            Context = usersContext;
        }
        public void AddWorker(Worker worker)
        {
            Context.Workers.Add(worker);
            Save();
        }

        public void DeleteWorker(int code)
        {
            var worker = Context.Workers.Where(x => x.Code == code).FirstOrDefault();
            Context.Workers.Remove(worker);
            Save();
        }

        public List<Worker> GetWorkers()
        {
            var list = Context.Workers.ToList();
            return list;
        }
        private void Save()
        {
            Context.SaveChanges();
        }
    }
}
