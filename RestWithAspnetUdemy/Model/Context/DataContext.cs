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
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
