using HM_DataBase.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace HM_DataBase.DataAccessLayer
{
    public class DataContext : DbContext
    {
        private ChangeTracker _changeTrackerManager;

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DataContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=postgres;Database=otus");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
