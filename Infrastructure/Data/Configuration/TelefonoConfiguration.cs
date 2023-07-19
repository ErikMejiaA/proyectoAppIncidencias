
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class TelefonoConfiguration : IEntityTypeConfiguration<Telefono>
{
    public void Configure(EntityTypeBuilder<Telefono> builder)
    {
        //definimos las propiedades de los atributos d ela entidad 

        builder.ToTable("Telefonos");

        builder.Property(p => p.Id_telefono)
        .IsRequired()
        .HasMaxLength(10);

        builder.Property(p => p.Numero_telefono)
        .IsRequired()
        .HasMaxLength(20);

        builder.HasIndex(p => p.Numero_telefono)
        .IsUnique();

        builder.Property(p => p.Tipo_telefono)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(100);

    }
}
