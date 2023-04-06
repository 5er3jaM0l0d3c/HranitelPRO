using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace qwer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        public IGroup Group { get; set; }
        public GroupController(IGroup group) { Group = group; }

        [HttpGet(nameof(GetGroups))]
        public List<Group> GetGroups()
        {
            return Group.GetGroups();
        }

        [HttpPost(nameof(AddGroup))]
        public void AddGroup(Group group)
        {
            Group.AddGroup(group);
        }

        [HttpDelete(nameof(DeleteGroup))]
        public void DeleteGroup(int id)
        {
            Group.DeleteGroup(id);
        }
    }
}
