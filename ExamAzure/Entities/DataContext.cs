using Microsoft.EntityFrameworkCore;

namespace ExamAzure.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }

    }
}
