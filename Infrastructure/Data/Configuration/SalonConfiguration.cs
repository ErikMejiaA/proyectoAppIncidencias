
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class SalonConfiguration : IEntityTypeConfiguration<Salon>
{
    public void Configure(EntityTypeBuilder<Salon> builder)
    {
        //definimos las propeiedades de los atributos de la entidad

        builder.ToTable("Salones");

        builder.Property(p => p.Id_salon)
        .IsRequired()
        .HasMaxLength(10);

        builder.Property(p => p.Nombre_salon)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Numero_puestos)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(100);

        //definimos la FOREIGN KEY
        
        builder.HasOne(p => p.Area)
        .WithMany(p => p.Salones)
        .HasForeignKey(p => p.Id_area)
        .IsRequired();

    }
}
