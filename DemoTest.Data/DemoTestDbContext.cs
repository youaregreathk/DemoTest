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

        public DbSet<User> Users{ get; set; }

        public DbSet<UserMetadata> UserMetadata { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("user");
            modelBuilder.Entity<UserMetadata>().ToTable("UserMetadata");

            modelBuilder.Entity<User>()
            .HasOne(a => a.UserMetadata)
            .WithOne(a => a.User)
            .HasForeignKey<User>(c => c.UserMetadataCorrelationId);
        }
    }
}
