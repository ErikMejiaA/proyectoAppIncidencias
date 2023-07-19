
using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class proyectoAppInsidenciasContext : DbContext
{
    public proyectoAppInsidenciasContext(DbContextOptions<proyectoAppInsidenciasContext> options) : base(options)
    {

    }

    //aqui van las DbSet<> de la entidades a implementar
    public DbSet<Area> ? Areas { get; set; }
    public DbSet<Categoria> ? Categorias { get; set; }
    public DbSet<Email_trainer> ? Emails_Trainers { get; set; }
    public DbSet<Email> ? Emails { get; set; }
    public DbSet<Hardware> ? Hardwares { get; set; }
    public DbSet<Incidencia> ? Incidencias { get; set; }
    public DbSet<Puesto> ? Puestos { get; set; }
    public DbSet<Salon> ? Salones { get; set; }
    public DbSet<Software> ? Softwares { get; set; }
    public DbSet<Telefono_trainer> ? Telefonos_Trainers { get; set; }
    public DbSet<Telefono> ? Telefonos { get; set; }
    public DbSet<Tipo_hardware> ? Tipos_Hardwares { get; set; }
    public DbSet<Tipo_incidencia> ? Tipos_Incidencias { get; set; }
    public DbSet<Tipo_software> ? Tipos_Softwares { get; set; }
    public DbSet<Trainer> ? Trainers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //definimos las llaves primarias compuestas para Email_trainer
        modelBuilder.Entity<Email_trainer>().HasKey(p => new { p.Id_email, p.Id_trainer });

        //definimos las llaves primarias compuestas para Telefono_trainer
        modelBuilder.Entity<Telefono_trainer>().HasKey(p => new { p.Id_telefono, p.Id_trainer});


        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }


    internal void SaveAsync()
    {
        throw new NotImplementedException();
    }

}
