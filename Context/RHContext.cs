using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrilhaNetAzureDesafio.Models;

namespace TrilhaNetAzureDesafio.Context
{
    public class RHContext : DbContext
    {
        public RHContext(DbContextOptions<RHContext> options) : base(options)
        {

        }

        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionario>()
            .Property(f => f.Salario)
            .HasColumnType("decimal(18,2)"); // Defina o tipo de dados do SQL Server para decimal(18,2) ou outro que seja apropriado para o seu caso

            base.OnModelCreating(modelBuilder);
        }
    }
}
