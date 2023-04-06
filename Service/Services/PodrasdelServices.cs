using Entities;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class PodrasdelServices : IPodrasdel
    {
        public UsersContext Context { get; set; }
        public PodrasdelServices(UsersContext usersContext) 
        {
            Context = usersContext;
        }
        public void AddPodrasdel(Podrasdel podrasdel)
        {
            Context.Podrasdels.Add(podrasdel);
            Save();
        }

        public void DeletePodrasdel(int id)
        {
            var podrasdel = Context.Podrasdels.Where(x => x.Id == id).FirstOrDefault();
            Context.Podrasdels.Remove(podrasdel);
        }

        public List<Podrasdel> GetPodrasdels()
        {
            var list = Context.Podrasdels.ToList();
            return list;
        }
        private void Save()
        {
            Context.SaveChanges();
        }
    }
}
