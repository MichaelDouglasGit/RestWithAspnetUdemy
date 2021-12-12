using Microsoft.EntityFrameworkCore;

namespace RestWithAspnetUdemy.Model.Context
{
    public class DataContext : DbContext
    {

        public DataContext() : base()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Person> Persons { get; set; }

    }
}
