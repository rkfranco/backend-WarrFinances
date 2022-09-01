using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T, R> : ControllerBase where T : BaseModel where R : BaseRepository<T>
    {
        private BaseRepository<T> repository;
        public GenericController()
        {
            repository = Activator.CreateInstance<R>();
        }

        [HttpGet]
        public List<T> GetAll()
        {
            return repository.GetAll();
        }

        [HttpPost]
        public void Post(T model)
        {
            repository.Create(model);
        }

        [HttpPut]
        public void Update(T model)
        {
            repository.Update(model);
        }

        [HttpDelete]
        public void Delete(T model)
        {
            repository.Delete(model);
        }
    }
}
