using Api_Sag.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api_Sag.Context
{
    public class SagContext : DbContext
    {
        public SagContext(DbContextOptions<SagContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        DbSet<Funcionarios> Funcionarios { get; set; }
        DbSet<Caixa> Caixa { get; set; }
    }
}
