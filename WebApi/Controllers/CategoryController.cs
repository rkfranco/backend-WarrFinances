using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : GenericController<Category, CategoryRepository>
    {
        public CategoryController() : base(new CategoryRepository())
        {
        }
    }
}
