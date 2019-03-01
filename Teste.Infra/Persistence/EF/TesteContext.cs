using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities;
using Teste.Infra.Persistence.EF.Map;
using Teste.Shared;

namespace Teste.Infra.Persistence.EF
{
    public class TesteContext : DbContext
    {

        public TesteContext(DbContextOptions<TesteContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
               

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(Settings.ConnectionString);

            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //ignorar classes
            //aplicar configurações
            modelBuilder.ApplyConfiguration(new MapCategoria());
            modelBuilder.ApplyConfiguration(new MapUsuario());
            modelBuilder.ApplyConfiguration(new MapLancamento());

            base.OnModelCreating(modelBuilder);


        }


    }
}
