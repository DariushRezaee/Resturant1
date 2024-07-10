using Microsoft.EntityFrameworkCore;
using Resturant.DbTables;

namespace Resturant.Db
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<MyCustomers> Customers { get; set; }
        public DbSet<Orders> MyOrders { get; set; }
        public DbSet<Foods> Food { get; set; }
        public DbSet<FoodOrderStatus> Status { get; set; }
        public DbSet<Comments> Comment { get; set; }
        public DbSet<LikeManagement> likes { get; set; }
        
    }
}
