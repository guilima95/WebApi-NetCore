using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.Domain.Entities;

namespace Teste.Infra.Persistence.EF.Map
{
    public class MapLancamento : IEntityTypeConfiguration<Lancamento>

    {
        public void Configure(EntityTypeBuilder<Lancamento> builder)
        {
            builder.ToTable("Lancamento");

            builder.HasKey(x => x.id);
            builder.Property(a => a.data).HasColumnName("data").IsRequired();
            builder.Property(a => a.descricao).HasColumnName("descricao").IsRequired();
            builder.Property(a => a.idUsuario).HasColumnName("idusuario").IsRequired();
            builder.Property(a => a.valor).HasColumnName("valor").IsRequired();
            builder.Property(a => a.tipo).HasColumnName("tipo").IsRequired();
        }
    }
}
