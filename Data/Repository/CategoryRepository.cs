using Data.Context;
using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class CategoryRepository : BaseRepository<Category>
    {
        // Sobrescrita para fazer a junção do usuario linkado a uma categoria
        public List<Category> GetAllUserCategory(int userId)
        {
            List<Category> list = new List<Category>();

            using (WarrContext warrContext = new WarrContext())
            {
                list = warrContext.Category.Where(category => category.UserId == userId).ToList();
            }
            return list;
        }
    }
}
