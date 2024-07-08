using Microsoft.EntityFrameworkCore;
using Resturant.DbTables;

namespace Resturant.Db
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<MyCustomers> Moshtari { get; set; }
    }
}
