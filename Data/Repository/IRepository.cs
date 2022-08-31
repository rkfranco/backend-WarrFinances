using Data.Model;

namespace Data.Repository
{
    public interface IRepository<T> where T : BaseModel
    {
        void Create(T model);

        List<T> GetAll();

        void Update(T model);

        void Delete(T model);

    }
}
