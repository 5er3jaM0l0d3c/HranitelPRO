using System;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IGroup
    {
        List<Entities.Group> GetGroups();
        void AddGroup(Entities.Group group);
        void DeleteGroup(int id);
    }
}
