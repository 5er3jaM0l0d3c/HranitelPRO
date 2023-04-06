using Entities;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IOtdel
    {
        List<Otdel> GetOtdels();
        void AddOtdel(Otdel otdel);
        void DeleteOtdel(int id);
    }
}
