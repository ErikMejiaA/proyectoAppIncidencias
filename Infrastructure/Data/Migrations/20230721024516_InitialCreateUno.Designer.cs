﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(proyectoAppInsidenciasContext))]
    [Migration("20230721024516_InitialCreateUno")]
    partial class InitialCreateUno
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Area", b =>
                {
                    b.Property<string>("Id_area")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nombre_area")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id_area");

                    b.ToTable("Areas", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Categoria", b =>
                {
                    b.Property<string>("Id_categoria")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nombre_categoria")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id_categoria");

                    b.ToTable("Categorias", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Email", b =>
                {
                    b.Property<string>("Id_email")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Tipo_email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id_email");

                    b.ToTable("Tipos_emails", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Email_trainer", b =>
                {
                    b.Property<string>("Id_email")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Id_trainer")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Email_correo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id_email", "Id_trainer");

                    b.HasIndex("Email_correo")
                        .IsUnique();

                    b.HasIndex("Id_trainer");

                    b.ToTable("Emails_trainers", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Hardware", b =>
                {
                    b.Property<string>("Id_hardware")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Id_categoria")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Id_puesto")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Id_tipo_hardware")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id_hardware");

                    b.HasIndex("Id_categoria");

                    b.HasIndex("Id_puesto");

                    b.HasIndex("Id_tipo_hardware");

                    b.ToTable("Hardwares", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Incidencia", b =>
                {
                    b.Property<string>("Id_incidencia")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("Fecha_reporte")
                        .HasColumnType("datetime");

                    b.Property<string>("Id_categoria")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Id_puesto")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Id_tipo_incidencia")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Id_trainer")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id_incidencia");

                    b.HasIndex("Id_categoria");

                    b.HasIndex("Id_puesto");

                    b.HasIndex("Id_tipo_incidencia");

                    b.HasIndex("Id_trainer");

                    b.ToTable("Incidencias", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Puesto", b =>
                {
                    b.Property<string>("Id_puesto")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Id_salon")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Nombre_puesto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id_puesto");

                    b.HasIndex("Id_salon");

                    b.ToTable("Puestos", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Salon", b =>
                {
                    b.Property<string>("Id_salon")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Id_area")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Nombre_salon")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Numero_puestos")
                        .HasColumnType("int");

                    b.HasKey("Id_salon");

                    b.HasIndex("Id_area");

                    b.ToTable("Salones", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Software", b =>
                {
                    b.Property<string>("Id_software")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Id_categoria")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Id_puesto")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Id_tipo_software")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id_software");

                    b.HasIndex("Id_categoria");

                    b.HasIndex("Id_puesto");

                    b.HasIndex("Id_tipo_software");

                    b.ToTable("Softwares", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Telefono", b =>
                {
                    b.Property<string>("Id_telefono")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Tipo_telefono")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id_telefono");

                    b.ToTable("Tipos_telefonos", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Telefono_trainer", b =>
                {
                    b.Property<string>("Id_telefono")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Id_trainer")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Numero_telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id_telefono", "Id_trainer");

                    b.HasIndex("Id_trainer");

                    b.HasIndex("Numero_telefono")
                        .IsUnique();

                    b.ToTable("Telefonos_trainers", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Tipo_hardware", b =>
                {
                    b.Property<string>("Id_tipo_hardware")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nombre_hardware")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id_tipo_hardware");

                    b.ToTable("Tipos_hardwares", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Tipo_incidencia", b =>
                {
                    b.Property<string>("Id_tipo_incidencia")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nombre_incidencia_nivel")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id_tipo_incidencia");

                    b.ToTable("Tipos_incidencias", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Tipo_software", b =>
                {
                    b.Property<string>("Id_tipo_software")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Decripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nombre_software")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id_tipo_software");

                    b.ToTable("Tipos_softwares", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Trainer", b =>
                {
                    b.Property<string>("Id_trainer")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nombre_trainer")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id_trainer");

                    b.ToTable("Trainers", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Email_trainer", b =>
                {
                    b.HasOne("Core.Entities.Email", "Email")
                        .WithMany("Emails_Trainers")
                        .HasForeignKey("Id_email")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Trainer", "Trainer")
                        .WithMany("Emails_Trainers")
                        .HasForeignKey("Id_trainer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Email");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Core.Entities.Hardware", b =>
                {
                    b.HasOne("Core.Entities.Categoria", "Categoria")
                        .WithMany("Hardwares")
                        .HasForeignKey("Id_categoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Puesto", "Puesto")
                        .WithMany("Hardwares")
                        .HasForeignKey("Id_puesto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Tipo_hardware", "Tipo_hardware")
                        .WithMany("Hardwares")
                        .HasForeignKey("Id_tipo_hardware")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Puesto");

                    b.Navigation("Tipo_hardware");
                });

            modelBuilder.Entity("Core.Entities.Incidencia", b =>
                {
                    b.HasOne("Core.Entities.Categoria", "Categoria")
                        .WithMany("Incidencias")
                        .HasForeignKey("Id_categoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Puesto", "Puesto")
                        .WithMany("Incidencias")
                        .HasForeignKey("Id_puesto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Tipo_incidencia", "Tipo_Incidencia")
                        .WithMany("Incidencias")
                        .HasForeignKey("Id_tipo_incidencia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Trainer", "Trainer")
                        .WithMany("Incidencias")
                        .HasForeignKey("Id_trainer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Puesto");

                    b.Navigation("Tipo_Incidencia");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Core.Entities.Puesto", b =>
                {
                    b.HasOne("Core.Entities.Salon", "Salon")
                        .WithMany("Puestos")
                        .HasForeignKey("Id_salon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("Core.Entities.Salon", b =>
                {
                    b.HasOne("Core.Entities.Area", "Area")
                        .WithMany("Salones")
                        .HasForeignKey("Id_area")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");
                });

            modelBuilder.Entity("Core.Entities.Software", b =>
                {
                    b.HasOne("Core.Entities.Categoria", "Categoria")
                        .WithMany("Softwares")
                        .HasForeignKey("Id_categoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Puesto", "Puesto")
                        .WithMany("Softwares")
                        .HasForeignKey("Id_puesto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Tipo_software", "Tipo_software")
                        .WithMany("Softwares")
                        .HasForeignKey("Id_tipo_software")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Puesto");

                    b.Navigation("Tipo_software");
                });

            modelBuilder.Entity("Core.Entities.Telefono_trainer", b =>
                {
                    b.HasOne("Core.Entities.Telefono", "Telefono")
                        .WithMany("Telefonos_Trainers")
                        .HasForeignKey("Id_telefono")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Trainer", "Trainer")
                        .WithMany("Telefonos_Trainers")
                        .HasForeignKey("Id_trainer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Telefono");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Core.Entities.Area", b =>
                {
                    b.Navigation("Salones");
                });

            modelBuilder.Entity("Core.Entities.Categoria", b =>
                {
                    b.Navigation("Hardwares");

                    b.Navigation("Incidencias");

                    b.Navigation("Softwares");
                });

            modelBuilder.Entity("Core.Entities.Email", b =>
                {
                    b.Navigation("Emails_Trainers");
                });

            modelBuilder.Entity("Core.Entities.Puesto", b =>
                {
                    b.Navigation("Hardwares");

                    b.Navigation("Incidencias");

                    b.Navigation("Softwares");
                });

            modelBuilder.Entity("Core.Entities.Salon", b =>
                {
                    b.Navigation("Puestos");
                });

            modelBuilder.Entity("Core.Entities.Telefono", b =>
                {
                    b.Navigation("Telefonos_Trainers");
                });

            modelBuilder.Entity("Core.Entities.Tipo_hardware", b =>
                {
                    b.Navigation("Hardwares");
                });

            modelBuilder.Entity("Core.Entities.Tipo_incidencia", b =>
                {
                    b.Navigation("Incidencias");
                });

            modelBuilder.Entity("Core.Entities.Tipo_software", b =>
                {
                    b.Navigation("Softwares");
                });

            modelBuilder.Entity("Core.Entities.Trainer", b =>
                {
                    b.Navigation("Emails_Trainers");

                    b.Navigation("Incidencias");

                    b.Navigation("Telefonos_Trainers");
                });
#pragma warning restore 612, 618
        }
    }
}
