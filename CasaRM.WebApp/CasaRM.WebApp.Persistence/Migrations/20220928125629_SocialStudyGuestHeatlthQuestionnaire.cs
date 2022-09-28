using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasaRM.WebApp.Persistence.Migrations
{
    public partial class SocialStudyGuestHeatlthQuestionnaire : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aportes_EstudiosSociales_SocialStudyId",
                table: "Aportes");

            migrationBuilder.DropForeignKey(
                name: "FK_EstudiosSociales_SituacionHabitacional_SituacionHabitacionalId",
                table: "EstudiosSociales");

            migrationBuilder.DropForeignKey(
                name: "FK_GruposFamiliares_EstudiosSociales_SocialStudyId",
                table: "GruposFamiliares");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SituacionHabitacional",
                table: "SituacionHabitacional");

            migrationBuilder.RenameTable(
                name: "SituacionHabitacional",
                newName: "SituacionesHabitacionales");

            migrationBuilder.RenameColumn(
                name: "SocialStudyId",
                table: "GruposFamiliares",
                newName: "EstudioSocialId");

            migrationBuilder.RenameIndex(
                name: "IX_GruposFamiliares_SocialStudyId",
                table: "GruposFamiliares",
                newName: "IX_GruposFamiliares_EstudioSocialId");

            migrationBuilder.RenameColumn(
                name: "Onservaciones",
                table: "DatosPersonasMenores",
                newName: "Observaciones");

            migrationBuilder.RenameColumn(
                name: "Onservaciones",
                table: "DatosEncargados",
                newName: "Observaciones");

            migrationBuilder.RenameColumn(
                name: "Onservaciones",
                table: "DatosAcompannantes",
                newName: "Observaciones");

            migrationBuilder.RenameColumn(
                name: "SocialStudyId",
                table: "Aportes",
                newName: "EstudioSocialId");

            migrationBuilder.RenameIndex(
                name: "IX_Aportes_SocialStudyId",
                table: "Aportes",
                newName: "IX_Aportes_EstudioSocialId");

            migrationBuilder.AddColumn<int>(
                name: "CuestionarioSaludHuespedId",
                table: "EstudiosSociales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SituacionesHabitacionales",
                table: "SituacionesHabitacionales",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CuestionariosSaludHuespedes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pregunta1 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta2 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta3 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta4 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta5 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta6 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta7 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta8 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta9 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta10 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta11 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta12 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta13 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta14 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta15 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta16 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta17 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta18 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta19 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuestionariosSaludHuespedes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstudiosSociales_CuestionarioSaludHuespedId",
                table: "EstudiosSociales",
                column: "CuestionarioSaludHuespedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aportes_EstudiosSociales_EstudioSocialId",
                table: "Aportes",
                column: "EstudioSocialId",
                principalTable: "EstudiosSociales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EstudiosSociales_CuestionariosSaludHuespedes_CuestionarioSaludHuespedId",
                table: "EstudiosSociales",
                column: "CuestionarioSaludHuespedId",
                principalTable: "CuestionariosSaludHuespedes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EstudiosSociales_SituacionesHabitacionales_SituacionHabitacionalId",
                table: "EstudiosSociales",
                column: "SituacionHabitacionalId",
                principalTable: "SituacionesHabitacionales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GruposFamiliares_EstudiosSociales_EstudioSocialId",
                table: "GruposFamiliares",
                column: "EstudioSocialId",
                principalTable: "EstudiosSociales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aportes_EstudiosSociales_EstudioSocialId",
                table: "Aportes");

            migrationBuilder.DropForeignKey(
                name: "FK_EstudiosSociales_CuestionariosSaludHuespedes_CuestionarioSaludHuespedId",
                table: "EstudiosSociales");

            migrationBuilder.DropForeignKey(
                name: "FK_EstudiosSociales_SituacionesHabitacionales_SituacionHabitacionalId",
                table: "EstudiosSociales");

            migrationBuilder.DropForeignKey(
                name: "FK_GruposFamiliares_EstudiosSociales_EstudioSocialId",
                table: "GruposFamiliares");

            migrationBuilder.DropTable(
                name: "CuestionariosSaludHuespedes");

            migrationBuilder.DropIndex(
                name: "IX_EstudiosSociales_CuestionarioSaludHuespedId",
                table: "EstudiosSociales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SituacionesHabitacionales",
                table: "SituacionesHabitacionales");

            migrationBuilder.DropColumn(
                name: "CuestionarioSaludHuespedId",
                table: "EstudiosSociales");

            migrationBuilder.RenameTable(
                name: "SituacionesHabitacionales",
                newName: "SituacionHabitacional");

            migrationBuilder.RenameColumn(
                name: "EstudioSocialId",
                table: "GruposFamiliares",
                newName: "SocialStudyId");

            migrationBuilder.RenameIndex(
                name: "IX_GruposFamiliares_EstudioSocialId",
                table: "GruposFamiliares",
                newName: "IX_GruposFamiliares_SocialStudyId");

            migrationBuilder.RenameColumn(
                name: "Observaciones",
                table: "DatosPersonasMenores",
                newName: "Onservaciones");

            migrationBuilder.RenameColumn(
                name: "Observaciones",
                table: "DatosEncargados",
                newName: "Onservaciones");

            migrationBuilder.RenameColumn(
                name: "Observaciones",
                table: "DatosAcompannantes",
                newName: "Onservaciones");

            migrationBuilder.RenameColumn(
                name: "EstudioSocialId",
                table: "Aportes",
                newName: "SocialStudyId");

            migrationBuilder.RenameIndex(
                name: "IX_Aportes_EstudioSocialId",
                table: "Aportes",
                newName: "IX_Aportes_SocialStudyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SituacionHabitacional",
                table: "SituacionHabitacional",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Aportes_EstudiosSociales_SocialStudyId",
                table: "Aportes",
                column: "SocialStudyId",
                principalTable: "EstudiosSociales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EstudiosSociales_SituacionHabitacional_SituacionHabitacionalId",
                table: "EstudiosSociales",
                column: "SituacionHabitacionalId",
                principalTable: "SituacionHabitacional",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GruposFamiliares_EstudiosSociales_SocialStudyId",
                table: "GruposFamiliares",
                column: "SocialStudyId",
                principalTable: "EstudiosSociales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
