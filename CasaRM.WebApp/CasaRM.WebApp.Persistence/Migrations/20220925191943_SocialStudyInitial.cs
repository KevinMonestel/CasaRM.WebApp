using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasaRM.WebApp.Persistence.Migrations
{
    public partial class SocialStudyInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DatosAcompannante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompleto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Parentesco = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Identificacion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EstadoCivil = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nacionalidad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Escolaridad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefonos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ocupacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LugarDeTrabajo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Enfermedad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tratamiento = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Onservaciones = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosAcompannante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatosEncargado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompleto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Parentesco = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Identificacion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EstadoCivil = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nacionalidad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Escolaridad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefonos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ocupacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LugarDeTrabajo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Enfermedad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tratamiento = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Onservaciones = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosEncargado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatosPersonaMenor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompleto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NumeroExpediente = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Escolaridad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nacionalidad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Diagnostico = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ServicioAtencion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Tratamiento = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MedicoTratante = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Canton = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Distrito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DireccionExacta = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TipoSeguroSocial = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Onservaciones = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosPersonaMenor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstudioSocial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatosPersonaMenorId = table.Column<int>(type: "int", nullable: false),
                    DatosEncargadoId = table.Column<int>(type: "int", nullable: false),
                    DatosAcompannanteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudioSocial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstudioSocial_DatosAcompannante_DatosAcompannanteId",
                        column: x => x.DatosAcompannanteId,
                        principalTable: "DatosAcompannante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstudioSocial_DatosEncargado_DatosEncargadoId",
                        column: x => x.DatosEncargadoId,
                        principalTable: "DatosEncargado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstudioSocial_DatosPersonaMenor_DatosPersonaMenorId",
                        column: x => x.DatosPersonaMenorId,
                        principalTable: "DatosPersonaMenor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contributions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialStudyId = table.Column<int>(type: "int", nullable: false),
                    NombreCompleto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Parentesco = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Ocupacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AporteMensual = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contributions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contributions_EstudioSocial_SocialStudyId",
                        column: x => x.SocialStudyId,
                        principalTable: "EstudioSocial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FamilyGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialStudyId = table.Column<int>(type: "int", nullable: false),
                    NombreCompleto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Parentesco = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    EstadoCivil = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Escolaridad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ocupacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IngresoBrutoMensual = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FamilyGroup_EstudioSocial_SocialStudyId",
                        column: x => x.SocialStudyId,
                        principalTable: "EstudioSocial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Huespedes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EstudioSocialId = table.Column<int>(type: "int", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huespedes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Huespedes_EstudioSocial_EstudioSocialId",
                        column: x => x.EstudioSocialId,
                        principalTable: "EstudioSocial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Huespedes_Usuarios_CreadoPor",
                        column: x => x.CreadoPor,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contributions_SocialStudyId",
                table: "Contributions",
                column: "SocialStudyId");

            migrationBuilder.CreateIndex(
                name: "IX_EstudioSocial_DatosAcompannanteId",
                table: "EstudioSocial",
                column: "DatosAcompannanteId");

            migrationBuilder.CreateIndex(
                name: "IX_EstudioSocial_DatosEncargadoId",
                table: "EstudioSocial",
                column: "DatosEncargadoId");

            migrationBuilder.CreateIndex(
                name: "IX_EstudioSocial_DatosPersonaMenorId",
                table: "EstudioSocial",
                column: "DatosPersonaMenorId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyGroup_SocialStudyId",
                table: "FamilyGroup",
                column: "SocialStudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Huespedes_CreadoPor",
                table: "Huespedes",
                column: "CreadoPor");

            migrationBuilder.CreateIndex(
                name: "IX_Huespedes_EstudioSocialId",
                table: "Huespedes",
                column: "EstudioSocialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contributions");

            migrationBuilder.DropTable(
                name: "FamilyGroup");

            migrationBuilder.DropTable(
                name: "Huespedes");

            migrationBuilder.DropTable(
                name: "EstudioSocial");

            migrationBuilder.DropTable(
                name: "DatosAcompannante");

            migrationBuilder.DropTable(
                name: "DatosEncargado");

            migrationBuilder.DropTable(
                name: "DatosPersonaMenor");
        }
    }
}
