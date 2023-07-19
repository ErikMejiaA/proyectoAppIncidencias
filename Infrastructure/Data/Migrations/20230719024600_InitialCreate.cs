using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id_area = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre_area = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id_area);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id_categoria = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre_categoria = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id_categoria);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id_email = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email_correo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tipo_email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id_email);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Telefonos",
                columns: table => new
                {
                    Id_telefono = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero_telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tipo_telefono = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefonos", x => x.Id_telefono);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tipos_hardwares",
                columns: table => new
                {
                    Id_tipo_hardware = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre_hardware = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_hardwares", x => x.Id_tipo_hardware);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tipos_incidencias",
                columns: table => new
                {
                    Id_tipo_incidencia = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre_incidencia_nivel = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_incidencias", x => x.Id_tipo_incidencia);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tipos_softwares",
                columns: table => new
                {
                    Id_tipo_software = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre_software = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Decripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_softwares", x => x.Id_tipo_software);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    Id_trainer = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre_trainer = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id_trainer);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Salones",
                columns: table => new
                {
                    Id_salon = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre_salon = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero_puestos = table.Column<int>(type: "int", nullable: false),
                    Descricion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_area = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salones", x => x.Id_salon);
                    table.ForeignKey(
                        name: "FK_Salones_Areas_Id_area",
                        column: x => x.Id_area,
                        principalTable: "Areas",
                        principalColumn: "Id_area",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Emails_trainers",
                columns: table => new
                {
                    Id_trainer = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_email = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails_trainers", x => new { x.Id_email, x.Id_trainer });
                    table.ForeignKey(
                        name: "FK_Emails_trainers_Emails_Id_email",
                        column: x => x.Id_email,
                        principalTable: "Emails",
                        principalColumn: "Id_email",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Emails_trainers_Trainers_Id_trainer",
                        column: x => x.Id_trainer,
                        principalTable: "Trainers",
                        principalColumn: "Id_trainer",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Telefonos_trainers",
                columns: table => new
                {
                    Id_trainer = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_telefono = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefonos_trainers", x => new { x.Id_telefono, x.Id_trainer });
                    table.ForeignKey(
                        name: "FK_Telefonos_trainers_Telefonos_Id_telefono",
                        column: x => x.Id_telefono,
                        principalTable: "Telefonos",
                        principalColumn: "Id_telefono",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Telefonos_trainers_Trainers_Id_trainer",
                        column: x => x.Id_trainer,
                        principalTable: "Trainers",
                        principalColumn: "Id_trainer",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Puestos",
                columns: table => new
                {
                    Id_puesto = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre_puesto = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_salon = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puestos", x => x.Id_puesto);
                    table.ForeignKey(
                        name: "FK_Puestos_Salones_Id_salon",
                        column: x => x.Id_salon,
                        principalTable: "Salones",
                        principalColumn: "Id_salon",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Hardwares",
                columns: table => new
                {
                    Id_hardware = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_tipo_hardware = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_puesto = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_categoria = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hardwares", x => x.Id_hardware);
                    table.ForeignKey(
                        name: "FK_Hardwares_Categorias_Id_categoria",
                        column: x => x.Id_categoria,
                        principalTable: "Categorias",
                        principalColumn: "Id_categoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hardwares_Puestos_Id_puesto",
                        column: x => x.Id_puesto,
                        principalTable: "Puestos",
                        principalColumn: "Id_puesto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hardwares_Tipos_hardwares_Id_tipo_hardware",
                        column: x => x.Id_tipo_hardware,
                        principalTable: "Tipos_hardwares",
                        principalColumn: "Id_tipo_hardware",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Incidencias",
                columns: table => new
                {
                    Id_incidencia = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fecha_reporte = table.Column<DateTime>(type: "datetime", nullable: false),
                    Id_tipo_incidencia = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_puesto = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_categoria = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_trainer = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidencias", x => x.Id_incidencia);
                    table.ForeignKey(
                        name: "FK_Incidencias_Categorias_Id_categoria",
                        column: x => x.Id_categoria,
                        principalTable: "Categorias",
                        principalColumn: "Id_categoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidencias_Puestos_Id_puesto",
                        column: x => x.Id_puesto,
                        principalTable: "Puestos",
                        principalColumn: "Id_puesto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidencias_Tipos_incidencias_Id_tipo_incidencia",
                        column: x => x.Id_tipo_incidencia,
                        principalTable: "Tipos_incidencias",
                        principalColumn: "Id_tipo_incidencia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidencias_Trainers_Id_trainer",
                        column: x => x.Id_trainer,
                        principalTable: "Trainers",
                        principalColumn: "Id_trainer",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Softwares",
                columns: table => new
                {
                    Id_software = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_tipo_software = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_puesto = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_categoria = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Softwares", x => x.Id_software);
                    table.ForeignKey(
                        name: "FK_Softwares_Categorias_Id_categoria",
                        column: x => x.Id_categoria,
                        principalTable: "Categorias",
                        principalColumn: "Id_categoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Softwares_Puestos_Id_puesto",
                        column: x => x.Id_puesto,
                        principalTable: "Puestos",
                        principalColumn: "Id_puesto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Softwares_Tipos_softwares_Id_software",
                        column: x => x.Id_software,
                        principalTable: "Tipos_softwares",
                        principalColumn: "Id_tipo_software",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_Email_correo",
                table: "Emails",
                column: "Email_correo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Emails_trainers_Id_trainer",
                table: "Emails_trainers",
                column: "Id_trainer");

            migrationBuilder.CreateIndex(
                name: "IX_Hardwares_Id_categoria",
                table: "Hardwares",
                column: "Id_categoria");

            migrationBuilder.CreateIndex(
                name: "IX_Hardwares_Id_puesto",
                table: "Hardwares",
                column: "Id_puesto");

            migrationBuilder.CreateIndex(
                name: "IX_Hardwares_Id_tipo_hardware",
                table: "Hardwares",
                column: "Id_tipo_hardware");

            migrationBuilder.CreateIndex(
                name: "IX_Incidencias_Id_categoria",
                table: "Incidencias",
                column: "Id_categoria");

            migrationBuilder.CreateIndex(
                name: "IX_Incidencias_Id_puesto",
                table: "Incidencias",
                column: "Id_puesto");

            migrationBuilder.CreateIndex(
                name: "IX_Incidencias_Id_tipo_incidencia",
                table: "Incidencias",
                column: "Id_tipo_incidencia");

            migrationBuilder.CreateIndex(
                name: "IX_Incidencias_Id_trainer",
                table: "Incidencias",
                column: "Id_trainer");

            migrationBuilder.CreateIndex(
                name: "IX_Puestos_Id_salon",
                table: "Puestos",
                column: "Id_salon");

            migrationBuilder.CreateIndex(
                name: "IX_Salones_Id_area",
                table: "Salones",
                column: "Id_area");

            migrationBuilder.CreateIndex(
                name: "IX_Softwares_Id_categoria",
                table: "Softwares",
                column: "Id_categoria");

            migrationBuilder.CreateIndex(
                name: "IX_Softwares_Id_puesto",
                table: "Softwares",
                column: "Id_puesto");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonos_Numero_telefono",
                table: "Telefonos",
                column: "Numero_telefono",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Telefonos_trainers_Id_trainer",
                table: "Telefonos_trainers",
                column: "Id_trainer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emails_trainers");

            migrationBuilder.DropTable(
                name: "Hardwares");

            migrationBuilder.DropTable(
                name: "Incidencias");

            migrationBuilder.DropTable(
                name: "Softwares");

            migrationBuilder.DropTable(
                name: "Telefonos_trainers");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "Tipos_hardwares");

            migrationBuilder.DropTable(
                name: "Tipos_incidencias");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Puestos");

            migrationBuilder.DropTable(
                name: "Tipos_softwares");

            migrationBuilder.DropTable(
                name: "Telefonos");

            migrationBuilder.DropTable(
                name: "Trainers");

            migrationBuilder.DropTable(
                name: "Salones");

            migrationBuilder.DropTable(
                name: "Areas");
        }
    }
}
