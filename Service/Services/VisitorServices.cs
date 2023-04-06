using Entities;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class VisitorServices : IVisitor
    {
        public UsersContext Context { get; set; }
        public VisitorServices(UsersContext context)
        {
            Context=context;
        }

        public void AddVisitor(Visitor visitor)
        {
            Context.Visitors.Add(visitor);
            Save();
        }

        public void DeleteVisitor(int id)
        {
            var visitor = Context.Visitors.Where(x => x.Id==id).FirstOrDefault();
            Context.Visitors.Remove(visitor);
            Save();
        }

        public List<Visitor> GetVisitors()
        {
            var list = Context.Visitors.ToList();
            return list;
        }
        private void Save()
        {
            Context.SaveChanges();
        }

        public List<Visitor> GetVisitorsOfGroup(int groupId)
        {
            var list = Context.Visitors.Where(x => x.GroupeId==groupId).ToList();
            return list;
        }
    }
}
