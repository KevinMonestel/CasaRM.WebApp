using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasaRM.WebApp.Persistence.Migrations
{
    public partial class HostingHistoryTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistorialesHospedajes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HuespedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreadoEn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialesHospedajes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistorialesHospedajes_Huespedes_HuespedId",
                        column: x => x.HuespedId,
                        principalTable: "Huespedes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistorialesHospedajes_Usuarios_CreadoPor",
                        column: x => x.CreadoPor,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistorialesHospedajes_CreadoPor",
                table: "HistorialesHospedajes",
                column: "CreadoPor",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HistorialesHospedajes_HuespedId",
                table: "HistorialesHospedajes",
                column: "HuespedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistorialesHospedajes");
        }
    }
}
