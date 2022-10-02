using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasaRM.WebApp.Persistence.Migrations
{
    public partial class Point23Unified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstudiosSociales_DatosAcompannantes_DatosAcompannanteId",
                table: "EstudiosSociales");

            migrationBuilder.DropForeignKey(
                name: "FK_EstudiosSociales_DatosEncargados_DatosEncargadoId",
                table: "EstudiosSociales");

            migrationBuilder.DropTable(
                name: "DatosEncargados");

            migrationBuilder.DropIndex(
                name: "IX_EstudiosSociales_DatosAcompannanteId",
                table: "EstudiosSociales");

            migrationBuilder.DropIndex(
                name: "IX_EstudiosSociales_DatosEncargadoId",
                table: "EstudiosSociales");

            migrationBuilder.DropColumn(
                name: "DatosAcompannanteId",
                table: "EstudiosSociales");

            migrationBuilder.DropColumn(
                name: "DatosEncargadoId",
                table: "EstudiosSociales");

            migrationBuilder.AddColumn<bool>(
                name: "EsPersonaACargo",
                table: "DatosAcompannantes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "EstudioSocialId",
                table: "DatosAcompannantes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DatosAcompannantes_EstudioSocialId",
                table: "DatosAcompannantes",
                column: "EstudioSocialId");

            migrationBuilder.AddForeignKey(
                name: "FK_DatosAcompannantes_EstudiosSociales_EstudioSocialId",
                table: "DatosAcompannantes",
                column: "EstudioSocialId",
                principalTable: "EstudiosSociales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatosAcompannantes_EstudiosSociales_EstudioSocialId",
                table: "DatosAcompannantes");

            migrationBuilder.DropIndex(
                name: "IX_DatosAcompannantes_EstudioSocialId",
                table: "DatosAcompannantes");

            migrationBuilder.DropColumn(
                name: "EsPersonaACargo",
                table: "DatosAcompannantes");

            migrationBuilder.DropColumn(
                name: "EstudioSocialId",
                table: "DatosAcompannantes");

            migrationBuilder.AddColumn<int>(
                name: "DatosAcompannanteId",
                table: "EstudiosSociales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DatosEncargadoId",
                table: "EstudiosSociales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DatosEncargados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NombreCompleto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Identificacion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Enfermedad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EstadoCivil = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nacionalidad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Ocupacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefonos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Parentesco = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Escolaridad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tratamiento = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LugarDeTrabajo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosEncargados", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstudiosSociales_DatosAcompannanteId",
                table: "EstudiosSociales",
                column: "DatosAcompannanteId");

            migrationBuilder.CreateIndex(
                name: "IX_EstudiosSociales_DatosEncargadoId",
                table: "EstudiosSociales",
                column: "DatosEncargadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_EstudiosSociales_DatosAcompannantes_DatosAcompannanteId",
                table: "EstudiosSociales",
                column: "DatosAcompannanteId",
                principalTable: "DatosAcompannantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EstudiosSociales_DatosEncargados_DatosEncargadoId",
                table: "EstudiosSociales",
                column: "DatosEncargadoId",
                principalTable: "DatosEncargados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
