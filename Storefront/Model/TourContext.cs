using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Storefront.Model;

namespace Storefront.Model
{
    public class TourContext : DbContext
    {
        public TourContext(DbContextOptions<TourContext> options): base(options)
        {

        }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservations> Reservations { get; set; }
        public DbSet<Employee> Employees { get; set; }
       


    }
}
