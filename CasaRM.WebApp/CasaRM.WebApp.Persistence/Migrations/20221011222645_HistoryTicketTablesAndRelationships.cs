using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasaRM.WebApp.Persistence.Migrations
{
    public partial class HistoryTicketTablesAndRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BoletaHistorialEntregaId",
                table: "HistorialesHospedajes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BoletaHistorialRecibimientoId",
                table: "HistorialesHospedajes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BoletaHistorial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CantidadCamasIndividuales = table.Column<int>(type: "int", nullable: false),
                    CantidadCamasHospitalarias = table.Column<int>(type: "int", nullable: false),
                    CantidadCamasNido = table.Column<int>(type: "int", nullable: false),
                    CantidadSabanasElastico = table.Column<int>(type: "int", nullable: false),
                    CantidadSabanas = table.Column<int>(type: "int", nullable: false),
                    CantidadFundasAlmohadas = table.Column<int>(type: "int", nullable: false),
                    CantidadCobertoresAlmohadas = table.Column<int>(type: "int", nullable: false),
                    CantidadAlmohadas = table.Column<int>(type: "int", nullable: false),
                    CantidadEdredones = table.Column<int>(type: "int", nullable: false),
                    CantidadCobijas = table.Column<int>(type: "int", nullable: false),
                    CantidadMesasDeNoche = table.Column<int>(type: "int", nullable: false),
                    CantidadCuadrosDecorativos = table.Column<int>(type: "int", nullable: false),
                    CantidadCortinasBlackOut = table.Column<int>(type: "int", nullable: false),
                    CantidadDecoraciones = table.Column<int>(type: "int", nullable: false),
                    CantidadClosets = table.Column<int>(type: "int", nullable: false),
                    CantidadBanquetas = table.Column<int>(type: "int", nullable: false),
                    CantidadPannosBanno = table.Column<int>(type: "int", nullable: false),
                    CantidadPannosMano = table.Column<int>(type: "int", nullable: false),
                    CantidadTinas = table.Column<int>(type: "int", nullable: false),
                    CantidadCoches = table.Column<int>(type: "int", nullable: false),
                    CantidadEncierros = table.Column<int>(type: "int", nullable: false),
                    CantidadCunas = table.Column<int>(type: "int", nullable: false),
                    CantidadKitsAseo = table.Column<int>(type: "int", nullable: false),
                    RecorridoRelizado = table.Column<bool>(type: "bit", nullable: false),
                    LlavesEntregadas = table.Column<bool>(type: "bit", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreadoEn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoletaHistorial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoletaHistorial_Usuarios_CreadoPor",
                        column: x => x.CreadoPor,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistorialesHospedajes_BoletaHistorialEntregaId",
                table: "HistorialesHospedajes",
                column: "BoletaHistorialEntregaId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialesHospedajes_BoletaHistorialRecibimientoId",
                table: "HistorialesHospedajes",
                column: "BoletaHistorialRecibimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_BoletaHistorial_CreadoPor",
                table: "BoletaHistorial",
                column: "CreadoPor");

            migrationBuilder.AddForeignKey(
                name: "FK_HistorialesHospedajes_BoletaHistorial_BoletaHistorialEntregaId",
                table: "HistorialesHospedajes",
                column: "BoletaHistorialEntregaId",
                principalTable: "BoletaHistorial",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HistorialesHospedajes_BoletaHistorial_BoletaHistorialRecibimientoId",
                table: "HistorialesHospedajes",
                column: "BoletaHistorialRecibimientoId",
                principalTable: "BoletaHistorial",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistorialesHospedajes_BoletaHistorial_BoletaHistorialEntregaId",
                table: "HistorialesHospedajes");

            migrationBuilder.DropForeignKey(
                name: "FK_HistorialesHospedajes_BoletaHistorial_BoletaHistorialRecibimientoId",
                table: "HistorialesHospedajes");

            migrationBuilder.DropTable(
                name: "BoletaHistorial");

            migrationBuilder.DropIndex(
                name: "IX_HistorialesHospedajes_BoletaHistorialEntregaId",
                table: "HistorialesHospedajes");

            migrationBuilder.DropIndex(
                name: "IX_HistorialesHospedajes_BoletaHistorialRecibimientoId",
                table: "HistorialesHospedajes");

            migrationBuilder.DropColumn(
                name: "BoletaHistorialEntregaId",
                table: "HistorialesHospedajes");

            migrationBuilder.DropColumn(
                name: "BoletaHistorialRecibimientoId",
                table: "HistorialesHospedajes");
        }
    }
}
