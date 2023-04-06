using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IPodrasdel
    {
        List<Podrasdel> GetPodrasdels();
        void AddPodrasdel(Podrasdel podrasdel);
        void DeletePodrasdel(int id);
    }
}
