using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasaRM.WebApp.Persistence.Migrations
{
    public partial class HistoryTicketTableRenamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoletaHistorial_Usuarios_CreadoPor",
                table: "BoletaHistorial");

            migrationBuilder.DropForeignKey(
                name: "FK_HistorialesHospedajes_BoletaHistorial_BoletaHistorialEntregaId",
                table: "HistorialesHospedajes");

            migrationBuilder.DropForeignKey(
                name: "FK_HistorialesHospedajes_BoletaHistorial_BoletaHistorialRecibimientoId",
                table: "HistorialesHospedajes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BoletaHistorial",
                table: "BoletaHistorial");

            migrationBuilder.RenameTable(
                name: "BoletaHistorial",
                newName: "BoletasHistoriales");

            migrationBuilder.RenameIndex(
                name: "IX_BoletaHistorial_CreadoPor",
                table: "BoletasHistoriales",
                newName: "IX_BoletasHistoriales_CreadoPor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BoletasHistoriales",
                table: "BoletasHistoriales",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BoletasHistoriales_Usuarios_CreadoPor",
                table: "BoletasHistoriales",
                column: "CreadoPor",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HistorialesHospedajes_BoletasHistoriales_BoletaHistorialEntregaId",
                table: "HistorialesHospedajes",
                column: "BoletaHistorialEntregaId",
                principalTable: "BoletasHistoriales",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HistorialesHospedajes_BoletasHistoriales_BoletaHistorialRecibimientoId",
                table: "HistorialesHospedajes",
                column: "BoletaHistorialRecibimientoId",
                principalTable: "BoletasHistoriales",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoletasHistoriales_Usuarios_CreadoPor",
                table: "BoletasHistoriales");

            migrationBuilder.DropForeignKey(
                name: "FK_HistorialesHospedajes_BoletasHistoriales_BoletaHistorialEntregaId",
                table: "HistorialesHospedajes");

            migrationBuilder.DropForeignKey(
                name: "FK_HistorialesHospedajes_BoletasHistoriales_BoletaHistorialRecibimientoId",
                table: "HistorialesHospedajes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BoletasHistoriales",
                table: "BoletasHistoriales");

            migrationBuilder.RenameTable(
                name: "BoletasHistoriales",
                newName: "BoletaHistorial");

            migrationBuilder.RenameIndex(
                name: "IX_BoletasHistoriales_CreadoPor",
                table: "BoletaHistorial",
                newName: "IX_BoletaHistorial_CreadoPor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BoletaHistorial",
                table: "BoletaHistorial",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BoletaHistorial_Usuarios_CreadoPor",
                table: "BoletaHistorial",
                column: "CreadoPor",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
