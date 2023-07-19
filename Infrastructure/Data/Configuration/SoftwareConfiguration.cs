
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class SoftwareConfiguration : IEntityTypeConfiguration<Software>
{
    public void Configure(EntityTypeBuilder<Software> builder)
    {
        //definimos las propiedades de los atributos d e la entidad

        builder.ToTable("Softwares");

        builder.Property(p => p.Id_software)
        .IsRequired()
        .HasMaxLength(10);

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(100);

        //definimos las FOREIGN KRY

        builder.HasOne(p => p.Tipo_software)
        .WithMany(p => p.Softwares)
        .HasForeignKey(p => p.Id_software)
        .IsRequired();

        builder.HasOne(p => p.Categoria)
        .WithMany(p => p.Softwares)
        .HasForeignKey(p => p.Id_categoria)
        .IsRequired();

        builder.HasOne(p => p.Puesto)
        .WithMany(p => p.Softwares)
        .HasForeignKey(p => p.Id_puesto)
        .IsRequired();

    }
}
