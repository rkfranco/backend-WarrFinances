using Data.Context;
using Data.Model;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public virtual void Create(T model)
        {
            using (WarrContext warrContext = new WarrContext())
            {
                warrContext.Set<T>().Add(model);
                warrContext.SaveChanges();
            }
        }

        public virtual void Delete(T model)
        {
            using (WarrContext warrContext = new WarrContext())
            {
                warrContext.Set<T>().Remove(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                warrContext.SaveChanges();
            }
        }

        public virtual List<T> GetAll()
        {
            List<T> list;
            using (WarrContext warrContext = new WarrContext())
            {
                list = warrContext.Set<T>().ToList();
            }
            return list;
        }

        public virtual void Update(T model)
        {
            using (WarrContext warrContext = new WarrContext())
            {
                warrContext.Entry<T>(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                warrContext.SaveChanges();
            }
        }
    }
}
