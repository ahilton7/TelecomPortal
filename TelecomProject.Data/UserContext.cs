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

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=DESKTOP-RMQDHKI;Initial Catalog=TelecomProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        //                                   .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
        //                                   .EnableSensitiveDataLogging();
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Device>()
                .HasIndex(e => e.Phone_number)
                .IsUnique();
        }
    }
}
