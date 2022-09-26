using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasaRM.WebApp.Persistence.Migrations
{
    public partial class SocialStudyFixesNullables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstudiosSociales_DatosAcompannantes_DatosAcompannanteId",
                table: "EstudiosSociales");

            migrationBuilder.DropForeignKey(
                name: "FK_EstudiosSociales_DatosEncargados_DatosEncargadoId",
                table: "EstudiosSociales");

            migrationBuilder.DropForeignKey(
                name: "FK_EstudiosSociales_DatosPersonasMenores_DatosPersonaMenorId",
                table: "EstudiosSociales");

            migrationBuilder.AlterColumn<int>(
                name: "DatosPersonaMenorId",
                table: "EstudiosSociales",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DatosEncargadoId",
                table: "EstudiosSociales",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DatosAcompannanteId",
                table: "EstudiosSociales",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_EstudiosSociales_DatosPersonasMenores_DatosPersonaMenorId",
                table: "EstudiosSociales",
                column: "DatosPersonaMenorId",
                principalTable: "DatosPersonasMenores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstudiosSociales_DatosAcompannantes_DatosAcompannanteId",
                table: "EstudiosSociales");

            migrationBuilder.DropForeignKey(
                name: "FK_EstudiosSociales_DatosEncargados_DatosEncargadoId",
                table: "EstudiosSociales");

            migrationBuilder.DropForeignKey(
                name: "FK_EstudiosSociales_DatosPersonasMenores_DatosPersonaMenorId",
                table: "EstudiosSociales");

            migrationBuilder.AlterColumn<int>(
                name: "DatosPersonaMenorId",
                table: "EstudiosSociales",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DatosEncargadoId",
                table: "EstudiosSociales",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DatosAcompannanteId",
                table: "EstudiosSociales",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_EstudiosSociales_DatosAcompannantes_DatosAcompannanteId",
                table: "EstudiosSociales",
                column: "DatosAcompannanteId",
                principalTable: "DatosAcompannantes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EstudiosSociales_DatosEncargados_DatosEncargadoId",
                table: "EstudiosSociales",
                column: "DatosEncargadoId",
                principalTable: "DatosEncargados",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EstudiosSociales_DatosPersonasMenores_DatosPersonaMenorId",
                table: "EstudiosSociales",
                column: "DatosPersonaMenorId",
                principalTable: "DatosPersonasMenores",
                principalColumn: "Id");
        }
    }
}
