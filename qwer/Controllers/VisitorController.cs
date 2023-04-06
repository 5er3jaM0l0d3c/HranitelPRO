using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace qwer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        public IVisitor Visitor { get; set; }
        public VisitorController(IVisitor visitor)
        {
            Visitor = visitor;
        }

        [HttpGet(nameof(GetVisitors))]
        public List<Visitor> GetVisitors()
        {
            return Visitor.GetVisitors();
        }

        [HttpGet(nameof(GetVisitorsOfGroup))]
        public List<Visitor> GetVisitorsOfGroup(int groupeId)
        {
            return Visitor.GetVisitorsOfGroup(groupeId);
        }

        [HttpPost(nameof(AddVisitor))]
        public void AddVisitor(Visitor visitor)
        {
            Visitor.AddVisitor(visitor);
        }

        [HttpDelete(nameof(DeleteVisitor))]
        public void DeleteVisitor(int id) 
        {
            Visitor.DeleteVisitor(id);
        }
    }
}
