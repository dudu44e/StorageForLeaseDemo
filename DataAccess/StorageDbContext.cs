using Microsoft.EntityFrameworkCore;
using StorageLease.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageLease.DataAccess
{
    public class StorageDbContext : DbContext
    {
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Storages> Storages { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=StorageDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }
    }
}
