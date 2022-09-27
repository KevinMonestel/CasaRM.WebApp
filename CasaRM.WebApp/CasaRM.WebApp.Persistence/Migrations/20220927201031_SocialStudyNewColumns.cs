using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasaRM.WebApp.Persistence.Migrations
{
    public partial class SocialStudyNewColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoriaPobreza",
                table: "EstudiosSociales",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "IngresoPerCapita",
                table: "EstudiosSociales",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalIngresos",
                table: "EstudiosSociales",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoriaPobreza",
                table: "EstudiosSociales");

            migrationBuilder.DropColumn(
                name: "IngresoPerCapita",
                table: "EstudiosSociales");

            migrationBuilder.DropColumn(
                name: "TotalIngresos",
                table: "EstudiosSociales");
        }
    }
}
