using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTapiEx1.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql("Host=10.245.79.17;Database=testdb;Username=dbuser;Password=dbuser");
            //optionsBuilder.UseNpgsql("Host=10.245.79.17;Database=testdb;Username=dbuser;");
            optionsBuilder.UseNpgsql("Host=192.168.56.1;Database=testdb;Username=dbuser;");
        }
    }
}
