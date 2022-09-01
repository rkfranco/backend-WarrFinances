using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : GenericController<Operation, OperationRepository>
    {
        public OperationController()
        {
        }



        [HttpGet("Month")]
        public List<List<Operation>> OperationMonth([FromQuery] DateTime date, int userId)
        {
            OperationRepository operationRepository = new OperationRepository();
            return operationRepository.SelectMonth(date, userId);
        }

        [HttpGet("id")]
        public Operation GetById(int id)
        {
            OperationRepository operationRepository = new OperationRepository();
            return operationRepository.SelectById(id);
        }


    }
}
