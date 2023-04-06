using Entities;
using Microsoft.EntityFrameworkCore;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service.Services
{
    public class GroupServices : IGroup
    {
        public UsersContext Context { get; set; }
        public GroupServices(UsersContext usercontext)
        {
            Context = usercontext;
        }
        public void AddGroup(Entities.Group group)
        {
            Context.Groups.Add(group);
            Save();
        }

        public void DeleteGroup(int id)
        {
            var group = Context.Groups.Where(x => x.Id == id).FirstOrDefault();
            Context.Groups.Remove(group);
            Save();
        }

        public List<Entities.Group> GetGroups()
        {
            var list = Context.Groups.ToList();
            return list;
        }

        private void Save()
        {
            Context.SaveChanges();
        }
    }
}
