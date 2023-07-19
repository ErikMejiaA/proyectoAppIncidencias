
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class Telefono_trainerConfiguration : IEntityTypeConfiguration<Telefono_trainer>
{
    public void Configure(EntityTypeBuilder<Telefono_trainer> builder)
    {
        //definimos las propiedades de los atributos de la entidad 

        builder.ToTable("Telefonos_trainers");

        builder.Property(p => p.Numero_telefono)
        .IsRequired()
        .HasMaxLength(20);

        builder.HasIndex(p => p.Numero_telefono)
        .IsUnique();

        //definimos las FOREIGN KEY
        builder.HasOne(p => p.Trainer)
        .WithMany(p => p.Telefonos_Trainers)
        .HasForeignKey(p => p.Id_trainer)
        .IsRequired();

        builder.HasOne(p => p.Telefono)
        .WithMany(p => p.Telefonos_Trainers)
        .HasForeignKey(p => p.Id_telefono)
        .IsRequired();
    }
}
