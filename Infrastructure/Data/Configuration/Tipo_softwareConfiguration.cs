
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class Tipo_softwareConfiguration : IEntityTypeConfiguration<Tipo_software>
{
    public void Configure(EntityTypeBuilder<Tipo_software> builder)
    {
        //definicion de las propiedades de los atributos de la entidad

        builder.ToTable("Tipos_softwares");

        builder.Property(p =>  p.Id_tipo_software)
        .IsRequired()
        .HasMaxLength(10);

        builder.Property(p => p.Nombre_software)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Decripcion)
        .IsRequired()
        .HasMaxLength(100);

    }
}
