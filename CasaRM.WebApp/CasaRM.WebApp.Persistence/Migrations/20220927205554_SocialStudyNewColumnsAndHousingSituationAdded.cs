using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasaRM.WebApp.Persistence.Migrations
{
    public partial class SocialStudyNewColumnsAndHousingSituationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Observaciones",
                table: "EstudiosSociales",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RedesApoyo",
                table: "EstudiosSociales",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SituacionHabitacionalId",
                table: "EstudiosSociales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SituacionHabitacional",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CondicionTenenciaVivienda = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaterialConstruccionParedes = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaterialConstruccionPiso = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CantidadAposentos = table.Column<int>(type: "int", nullable: false),
                    CantidadDormitorios = table.Column<int>(type: "int", nullable: false),
                    CantidadBannos = table.Column<int>(type: "int", nullable: false),
                    EstadoConservacionVivienda = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ServiciosBasicos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SituacionHabitacional", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstudiosSociales_SituacionHabitacionalId",
                table: "EstudiosSociales",
                column: "SituacionHabitacionalId");

            migrationBuilder.AddForeignKey(
                name: "FK_EstudiosSociales_SituacionHabitacional_SituacionHabitacionalId",
                table: "EstudiosSociales",
                column: "SituacionHabitacionalId",
                principalTable: "SituacionHabitacional",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstudiosSociales_SituacionHabitacional_SituacionHabitacionalId",
                table: "EstudiosSociales");

            migrationBuilder.DropTable(
                name: "SituacionHabitacional");

            migrationBuilder.DropIndex(
                name: "IX_EstudiosSociales_SituacionHabitacionalId",
                table: "EstudiosSociales");

            migrationBuilder.DropColumn(
                name: "Observaciones",
                table: "EstudiosSociales");

            migrationBuilder.DropColumn(
                name: "RedesApoyo",
                table: "EstudiosSociales");

            migrationBuilder.DropColumn(
                name: "SituacionHabitacionalId",
                table: "EstudiosSociales");
        }
    }
}
