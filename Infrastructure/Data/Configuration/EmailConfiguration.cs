
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class EmailConfiguration : IEntityTypeConfiguration<Email>
{
    public void Configure(EntityTypeBuilder<Email> builder)
    {
        //definimos las propiedades de los atributos de la entidad

        builder.ToTable("Tipos_emails");

        builder.Property(p => p.Id_email)
        .IsRequired()
        .HasMaxLength(10);

        builder.Property(p => p.Tipo_email)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(100);

    }
}
