
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class PuestoConfiguration : IEntityTypeConfiguration<Puesto>
{
    public void Configure(EntityTypeBuilder<Puesto> builder)
    {
        //definimos las propiedades de los atributos de la entidad

        builder.ToTable("Puestos");

        builder.Property(p => p.Id_puesto)
        .IsRequired()
        .HasMaxLength(10);

        builder.Property(p => p.Nombre_puesto)
        .IsRequired()
        .HasMaxLength(50);

        //definimos la FOREIGN KEY

        builder.HasOne(p => p.Salon)
        .WithMany(p => p.Puestos)
        .HasForeignKey(p => p.Id_salon)
        .IsRequired();
    }
}
