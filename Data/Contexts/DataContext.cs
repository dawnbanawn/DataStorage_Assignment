using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Contexts {
    public class DataContext : DbContext { // Class inherits from dbcontext

        public DataContext(DbContextOptions<DataContext> options) : base(options) { // Constructor with options
        }

        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<StatusTypeEntity> StatusTypes { get; set; }
        public DbSet<UserEntity> Users { get; set; }

    }
}
