
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class AreaConfiguration : IEntityTypeConfiguration<Area>
{
    public void Configure(EntityTypeBuilder<Area> builder)
    {
        //definimos las porpiedades de los atributos de la entidad 
        
        builder.ToTable("Areas");

        builder.Property(p => p.Id_area)
        .IsRequired()
        .HasMaxLength(10);

        builder.Property(p => p.Nombre_area)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(100);
    }
}
