
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class HardwareConfiguration : IEntityTypeConfiguration<Hardware>
{
    public void Configure(EntityTypeBuilder<Hardware> builder)
    {
        //definimos las propiedades de los atributos de la entidad

        builder.ToTable("Hardwares");

        builder.Property(p => p.Id_hardware)
        .IsRequired()
        .HasMaxLength(10);

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(100);

        //definimos las FOREIGN KEY
        builder.HasOne(p => p.Puesto)
        .WithMany(p => p.Hardwares)
        .HasForeignKey(p => p.Id_puesto)
        .IsRequired();

        builder.HasOne(p => p.Categoria)
        .WithMany(p => p.Hardwares)
        .HasForeignKey(p => p.Id_categoria)
        .IsRequired();

        builder.HasOne(p => p.Tipo_hardware)
        .WithMany(p => p.Hardwares)
        .HasForeignKey(p => p.Id_tipo_hardware)
        .IsRequired();
    }
}
