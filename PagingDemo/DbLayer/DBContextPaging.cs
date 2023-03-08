using Microsoft.EntityFrameworkCore;
using PagingDemo.Models;

namespace PagingDemo.DbLayer
{
    public class DBContextPaging : DbContext
    {
        public DBContextPaging(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CustomersEntity> Customers { get; set; }
    }
}
