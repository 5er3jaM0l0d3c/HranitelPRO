using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Services;

namespace qwer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtdelController : ControllerBase
    {
        public IOtdel Otdel { get; set; }
        public OtdelController(IOtdel otdel) 
        {
            Otdel = otdel;
        }

        [HttpGet(nameof(GetOtdels))]
        public List<Otdel> GetOtdels() 
        {
            return Otdel.GetOtdels();
        }
        [HttpPost(nameof(AddOtdel))]
        public void AddOtdel(Otdel otdel) 
        {
            Otdel.AddOtdel(otdel);
        }
        [HttpDelete(nameof(DeleteOtdel))]
        public void DeleteOtdel(int id) 
        {
            Otdel.DeleteOtdel(id);
        }
    }
}
