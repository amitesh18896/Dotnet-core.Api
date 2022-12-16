using Customer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Customer.Domain
{
   public  class CustomerDbContext : DbContext

    {
        public  CustomerDbContext (DbContextOptions options) : base(options)
        {

        }
        public DbSet<CustomerUser> CustomerUsers { get; set; } 
    }
}
