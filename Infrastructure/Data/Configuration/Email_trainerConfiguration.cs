
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class Email_trainerConfiguration : IEntityTypeConfiguration<Email_trainer>
{
    public void Configure(EntityTypeBuilder<Email_trainer> builder)
    {
        //definimos las propiedades de los atributos de la entidad

        builder.ToTable("Emails_trainers");

        builder.Property(p => p.Email_correo)
        .IsRequired()
        .HasMaxLength(100);

        builder.HasIndex(p => p.Email_correo)
        .IsUnique();

        //definimos las FOREIGN KEY

        builder.HasOne(p => p.Email)
        .WithMany(p => p.Emails_Trainers)
        .HasForeignKey(p => p.Id_email)
        .IsRequired();

        builder.HasOne(p => p.Trainer)
        .WithMany(p => p.Emails_Trainers)
        .HasForeignKey(p => p.Id_trainer)
        .IsRequired();
    }
}
