﻿using Data.Model;
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

        [HttpGet("Month")]
        public List<List<Operation>> OperationMonth([FromQuery] DateTime date)
        {
            OperationRepository operationRepository = new OperationRepository();
            return operationRepository.SelectMonth(date);

        }


    }
}
