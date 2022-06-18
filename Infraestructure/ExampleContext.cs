using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;

namespace Infraestructure
{
    public class ExampleContext : DbContext
    {

        public ExampleContext() : base("name = MyContextDB")
        {

        }
        public DbSet<Person> People { get; set; }

        public DbSet<Producto> Product { get; set; }
    }
}
