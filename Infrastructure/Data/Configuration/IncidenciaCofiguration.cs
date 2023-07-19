
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class IncidenciaCofiguration : IEntityTypeConfiguration<Incidencia>
{
    public void Configure(EntityTypeBuilder<Incidencia> builder)
    {
        //definimos las propiedades de los atributos de la entidad

        builder.ToTable("Incidencias");

        builder.Property(p => p.Id_incidencia)
        .IsRequired()
        .HasMaxLength(10);

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p => p.Fecha_reporte)
        .IsRequired()
        .HasColumnType("datetime");

        //definimos las FOREIGN KEY 

        builder.HasOne(p => p.Tipo_Incidencia)
        .WithMany(p => p.Incidencias)
        .HasForeignKey(p => p.Id_tipo_incidencia)
        .IsRequired();

        builder.HasOne(p => p.Puesto)
        .WithMany(p => p.Incidencias)
        .HasForeignKey(p => p.Id_puesto)
        .IsRequired();

        builder.HasOne(p => p.Categoria)
        .WithMany(p => p.Incidencias)
        .HasForeignKey(p => p.Id_categoria)
        .IsRequired();

        builder.HasOne(p => p.Trainer)
        .WithMany(p => p.Incidencias)
        .HasForeignKey(p => p.Id_trainer)
        .IsRequired();

    }
}
