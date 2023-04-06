using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IVisitor
    {
        List<Visitor> GetVisitors();
        List<Visitor> GetVisitorsOfGroup(int groupId);
        void AddVisitor(Visitor visitor);
        void DeleteVisitor(int id);
    }
}
