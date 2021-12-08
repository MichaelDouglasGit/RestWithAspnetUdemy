using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace RestWithAspnetUdemy.Model.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base()
        {

        }

        public DataContext(DbContextOptions options) : base(options) {}

        public DbSet<Person> Persons { get; set; }



    }
}
