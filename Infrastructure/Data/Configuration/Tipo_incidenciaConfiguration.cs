
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class Tipo_incidenciaConfiguration : IEntityTypeConfiguration<Tipo_incidencia>
{
    public void Configure(EntityTypeBuilder<Tipo_incidencia> builder)
    {
        //definimos las propiedades de los atributos de la entidad 

        builder.ToTable("Tipos_incidencias");

        builder.Property(p => p.Id_tipo_incidencia)
        .IsRequired()
        .HasMaxLength(10);

        builder.Property(p => p.Nombre_incidencia_nivel)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(100);

    }
}
