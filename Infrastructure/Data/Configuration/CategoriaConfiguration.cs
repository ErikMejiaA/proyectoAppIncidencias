
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        //definimos las porpiedades de los atributos de la entidad 

        builder.ToTable("Categorias");

        builder.Property(p => p .Id_categoria)
        .IsRequired()
        .HasMaxLength(10);

        builder.Property(p => p.Nombre_categoria)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(100);
        
    }
}
