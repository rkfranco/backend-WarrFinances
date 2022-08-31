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
            optionsBuilder.UseNpgsql("Host=zuplae.vps-kinghost.net; Port=5445; Database=postgres; UserId=postgres; Password=123456");
        }
    }
}
