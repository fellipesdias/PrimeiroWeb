using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiroweb.Models
{
    public class Context : DbContext
        {
            public DbSet<categoria> Categorias { get; set; }
            public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString: @"User ID = postgres; Password = Fs310193; Host = localhost; Port = 5432; Database = webdb; Pooling = true;");
        }
    }

  
}
