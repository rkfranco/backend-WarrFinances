using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : GenericController<Category, CategoryRepository>
    {

        [HttpGet("UserCategories")]
        public List<Category> GetAllUserCategories(int id)
        {
            CategoryRepository repository = new CategoryRepository();
            return repository.GetAllUserCategory(id);
        }

    }
}
