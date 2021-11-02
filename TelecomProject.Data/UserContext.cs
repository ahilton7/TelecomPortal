using TelecomProject.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelecomProject.Data
{
    public class UserContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public DbSet<Plan> Plans { get; set; }

        public DbSet<Device> Devices { get; set; }


        public UserContext(DbContextOptions options): base(options) { }
        public UserContext() { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Device>()
                .HasIndex(e => e.Phone_number)
                .IsUnique();
        }
    }
}
