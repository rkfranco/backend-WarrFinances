using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class WarrContext : DbContext
    {
        #region Props
        public DbSet<User> User { get; set; }
        public DbSet<Operation> Operation { get; set; }
        public DbSet<Category> Category { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=grupo_5; Port=5432; Database=postgres; UserId=postgres; Password=123456");

        }
    }
}