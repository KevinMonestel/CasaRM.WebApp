using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasaRM.WebApp.Persistence.Migrations
{
    public partial class HostingHistoryTableIndexUniqueFalse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_HistorialesHospedajes_CreadoPor",
                table: "HistorialesHospedajes");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialesHospedajes_CreadoPor",
                table: "HistorialesHospedajes",
                column: "CreadoPor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_HistorialesHospedajes_CreadoPor",
                table: "HistorialesHospedajes");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialesHospedajes_CreadoPor",
                table: "HistorialesHospedajes",
                column: "CreadoPor",
                unique: true);
        }
    }
}
