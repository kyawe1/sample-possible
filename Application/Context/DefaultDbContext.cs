using Core.Entity;
using System.Data.Entity;

namespace Application.Context
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext() : base("DefaultDbContext")
        {

        }
        public DbSet<Enterprise> enterprises { set; get; }
        public DbSet<Consumer> consumers { set; get; }
        public DbSet<Outlet> outlets { set; get; }
        public DbSet<Product> products { set; get; }
        public DbSet<Employee> employees { set; get; }
        public DbSet<Payment> payments { set; get; }
        public DbSet<InventoryControl> inventoryControls { set; get; }
        public DbSet<Order> orders { set; get; }
        public DbSet<OrderDetail> orderDetails { set; get; }

    }
}
