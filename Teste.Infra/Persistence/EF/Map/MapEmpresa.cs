using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities;

namespace Teste.Infra.Persistence.EF.Map
{
    public class MapEmpresa : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa");

            builder.HasKey(x => x.Id);
            builder.Property(a => a.Enterprise_Types).HasColumnName("tipo").IsRequired();
            builder.Property(a => a.Name).HasColumnName("nome").IsRequired();


        }
    }
}
