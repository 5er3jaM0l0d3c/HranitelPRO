using Entities;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class OtdelServices : IOtdel
    {
        public UsersContext Context { get; set; }
        public OtdelServices(UsersContext usersContext)
        {
            Context = usersContext;
        }
        public void AddOtdel(Otdel otdel)
        {
            Context.Otdels.Add(otdel);
            Save();
        }

        public void DeleteOtdel(int id)
        {
            var otdel = Context.Otdels.Where(x => x.Id == id).FirstOrDefault();
            Context.Otdels.Remove(otdel);
            Save();
        }

        public List<Otdel> GetOtdels()
        {
            var list = Context.Otdels.ToList();
            return list;
        }
        private void Save()
        {
            Context.SaveChanges();
        }
    }
}
