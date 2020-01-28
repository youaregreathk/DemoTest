using DemoTest.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTest.Data
{
    public class DemoTestDbContext : DbContext
    {
        public DemoTestDbContext(DbContextOptions<DemoTestDbContext> options) 
            : base(options)
        { 
            
        }

        public DbSet<User> Users { get; set; }
    }
}
