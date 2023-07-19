using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateVersionDos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emails_trainers_Emails_Id_email",
                table: "Emails_trainers");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefonos_trainers_Telefonos_Id_telefono",
                table: "Telefonos_trainers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefonos",
                table: "Telefonos");

            migrationBuilder.DropIndex(
                name: "IX_Telefonos_Numero_telefono",
                table: "Telefonos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emails",
                table: "Emails");

            migrationBuilder.DropIndex(
                name: "IX_Emails_Email_correo",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "Numero_telefono",
                table: "Telefonos");

            migrationBuilder.DropColumn(
                name: "Email_correo",
                table: "Emails");

            migrationBuilder.RenameTable(
                name: "Telefonos",
                newName: "Tipos_telefonos");

            migrationBuilder.RenameTable(
                name: "Emails",
                newName: "Tipos_emails");

            migrationBuilder.AddColumn<string>(
                name: "Numero_telefono",
                table: "Telefonos_trainers",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Email_correo",
                table: "Emails_trainers",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipos_telefonos",
                table: "Tipos_telefonos",
                column: "Id_telefono");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipos_emails",
                table: "Tipos_emails",
                column: "Id_email");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonos_trainers_Numero_telefono",
                table: "Telefonos_trainers",
                column: "Numero_telefono",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Emails_trainers_Email_correo",
                table: "Emails_trainers",
                column: "Email_correo",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_trainers_Tipos_emails_Id_email",
                table: "Emails_trainers",
                column: "Id_email",
                principalTable: "Tipos_emails",
                principalColumn: "Id_email",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefonos_trainers_Tipos_telefonos_Id_telefono",
                table: "Telefonos_trainers",
                column: "Id_telefono",
                principalTable: "Tipos_telefonos",
                principalColumn: "Id_telefono",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emails_trainers_Tipos_emails_Id_email",
                table: "Emails_trainers");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefonos_trainers_Tipos_telefonos_Id_telefono",
                table: "Telefonos_trainers");

            migrationBuilder.DropIndex(
                name: "IX_Telefonos_trainers_Numero_telefono",
                table: "Telefonos_trainers");

            migrationBuilder.DropIndex(
                name: "IX_Emails_trainers_Email_correo",
                table: "Emails_trainers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipos_telefonos",
                table: "Tipos_telefonos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipos_emails",
                table: "Tipos_emails");

            migrationBuilder.DropColumn(
                name: "Numero_telefono",
                table: "Telefonos_trainers");

            migrationBuilder.DropColumn(
                name: "Email_correo",
                table: "Emails_trainers");

            migrationBuilder.RenameTable(
                name: "Tipos_telefonos",
                newName: "Telefonos");

            migrationBuilder.RenameTable(
                name: "Tipos_emails",
                newName: "Emails");

            migrationBuilder.AddColumn<string>(
                name: "Numero_telefono",
                table: "Telefonos",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Email_correo",
                table: "Emails",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefonos",
                table: "Telefonos",
                column: "Id_telefono");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emails",
                table: "Emails",
                column: "Id_email");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonos_Numero_telefono",
                table: "Telefonos",
                column: "Numero_telefono",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Emails_Email_correo",
                table: "Emails",
                column: "Email_correo",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_trainers_Emails_Id_email",
                table: "Emails_trainers",
                column: "Id_email",
                principalTable: "Emails",
                principalColumn: "Id_email",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefonos_trainers_Telefonos_Id_telefono",
                table: "Telefonos_trainers",
                column: "Id_telefono",
                principalTable: "Telefonos",
                principalColumn: "Id_telefono",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
