using Microsoft.EntityFrameworkCore;

namespace BE_PRM_API_Postgres.Models
{
    public class ShoppingCartDbContext :DbContext
    {
        public ShoppingCartDbContext(DbContextOptions<ShoppingCartDbContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }


        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }
    }

    

}
