using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : GenericController<Operation, OperationRepository>
    {
        public OperationController() : base(new OperationRepository())
        {
        }
    }
}
