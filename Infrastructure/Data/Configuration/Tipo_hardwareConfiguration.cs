
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class Tipo_hardwareConfiguration : IEntityTypeConfiguration<Tipo_hardware>
{
    public void Configure(EntityTypeBuilder<Tipo_hardware> builder)
    {
        //definimos las propiedades de los atributos de la entidad

        builder.ToTable("Tipos_hardwares");

        builder.Property(p => p.Nombre_hardware)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(100);


    }
}
