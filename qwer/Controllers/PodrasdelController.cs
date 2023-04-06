using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace qwer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PodrasdelController : ControllerBase
    {
        public IPodrasdel Podrasdel { get; set; }
        public PodrasdelController(IPodrasdel podrasdel) 
        {
            Podrasdel = podrasdel;
        }

        [HttpGet(nameof(GetPodrasdels))]
        public List<Podrasdel> GetPodrasdels() 
        {
            return Podrasdel.GetPodrasdels();
        }

        [HttpPost(nameof(AddPodrasdel))]
        public void AddPodrasdel(Podrasdel podrasdel)
        {
            Podrasdel.AddPodrasdel(podrasdel);
        }

        [HttpDelete(nameof(DeletePodrasdel))]
        public void DeletePodrasdel(int id)
        {
            Podrasdel.DeletePodrasdel(id);
        }
    }
}
