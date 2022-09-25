using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasaRM.WebApp.Persistence.Migrations
{
    public partial class SocialStudyChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contributions_EstudioSocial_SocialStudyId",
                table: "Contributions");

            migrationBuilder.DropForeignKey(
                name: "FK_FamilyGroup_EstudioSocial_SocialStudyId",
                table: "FamilyGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FamilyGroup",
                table: "FamilyGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contributions",
                table: "Contributions");

            migrationBuilder.RenameTable(
                name: "FamilyGroup",
                newName: "GrupoFamiliar");

            migrationBuilder.RenameTable(
                name: "Contributions",
                newName: "Aportes");

            migrationBuilder.RenameIndex(
                name: "IX_FamilyGroup_SocialStudyId",
                table: "GrupoFamiliar",
                newName: "IX_GrupoFamiliar_SocialStudyId");

            migrationBuilder.RenameIndex(
                name: "IX_Contributions_SocialStudyId",
                table: "Aportes",
                newName: "IX_Aportes_SocialStudyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GrupoFamiliar",
                table: "GrupoFamiliar",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Aportes",
                table: "Aportes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Aportes_EstudioSocial_SocialStudyId",
                table: "Aportes",
                column: "SocialStudyId",
                principalTable: "EstudioSocial",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GrupoFamiliar_EstudioSocial_SocialStudyId",
                table: "GrupoFamiliar",
                column: "SocialStudyId",
                principalTable: "EstudioSocial",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aportes_EstudioSocial_SocialStudyId",
                table: "Aportes");

            migrationBuilder.DropForeignKey(
                name: "FK_GrupoFamiliar_EstudioSocial_SocialStudyId",
                table: "GrupoFamiliar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GrupoFamiliar",
                table: "GrupoFamiliar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Aportes",
                table: "Aportes");

            migrationBuilder.RenameTable(
                name: "GrupoFamiliar",
                newName: "FamilyGroup");

            migrationBuilder.RenameTable(
                name: "Aportes",
                newName: "Contributions");

            migrationBuilder.RenameIndex(
                name: "IX_GrupoFamiliar_SocialStudyId",
                table: "FamilyGroup",
                newName: "IX_FamilyGroup_SocialStudyId");

            migrationBuilder.RenameIndex(
                name: "IX_Aportes_SocialStudyId",
                table: "Contributions",
                newName: "IX_Contributions_SocialStudyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FamilyGroup",
                table: "FamilyGroup",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contributions",
                table: "Contributions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contributions_EstudioSocial_SocialStudyId",
                table: "Contributions",
                column: "SocialStudyId",
                principalTable: "EstudioSocial",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FamilyGroup_EstudioSocial_SocialStudyId",
                table: "FamilyGroup",
                column: "SocialStudyId",
                principalTable: "EstudioSocial",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
