
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class TrainerConfiguration : IEntityTypeConfiguration<Trainer>
{
    public void Configure(EntityTypeBuilder<Trainer> builder)
    {
        //definimos las propiedades de los atributos de la entidad

        builder.ToTable("Trainers");

        builder.Property(p => p.Id_trainer)
        .IsRequired()
        .HasMaxLength(10);

        builder.Property(p => p.Nombre_trainer)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(100);
    }
}
