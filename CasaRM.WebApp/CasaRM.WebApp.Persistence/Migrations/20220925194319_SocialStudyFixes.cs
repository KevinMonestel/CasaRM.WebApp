using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasaRM.WebApp.Persistence.Migrations
{
    public partial class SocialStudyFixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aportes_EstudioSocial_SocialStudyId",
                table: "Aportes");

            migrationBuilder.DropForeignKey(
                name: "FK_EstudioSocial_DatosAcompannante_DatosAcompannanteId",
                table: "EstudioSocial");

            migrationBuilder.DropForeignKey(
                name: "FK_EstudioSocial_DatosEncargado_DatosEncargadoId",
                table: "EstudioSocial");

            migrationBuilder.DropForeignKey(
                name: "FK_EstudioSocial_DatosPersonaMenor_DatosPersonaMenorId",
                table: "EstudioSocial");

            migrationBuilder.DropForeignKey(
                name: "FK_GrupoFamiliar_EstudioSocial_SocialStudyId",
                table: "GrupoFamiliar");

            migrationBuilder.DropForeignKey(
                name: "FK_Huespedes_EstudioSocial_EstudioSocialId",
                table: "Huespedes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GrupoFamiliar",
                table: "GrupoFamiliar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstudioSocial",
                table: "EstudioSocial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DatosPersonaMenor",
                table: "DatosPersonaMenor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DatosEncargado",
                table: "DatosEncargado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DatosAcompannante",
                table: "DatosAcompannante");

            migrationBuilder.RenameTable(
                name: "GrupoFamiliar",
                newName: "GruposFamiliares");

            migrationBuilder.RenameTable(
                name: "EstudioSocial",
                newName: "EstudiosSociales");

            migrationBuilder.RenameTable(
                name: "DatosPersonaMenor",
                newName: "DatosPersonasMenores");

            migrationBuilder.RenameTable(
                name: "DatosEncargado",
                newName: "DatosEncargados");

            migrationBuilder.RenameTable(
                name: "DatosAcompannante",
                newName: "DatosAcompannantes");

            migrationBuilder.RenameIndex(
                name: "IX_GrupoFamiliar_SocialStudyId",
                table: "GruposFamiliares",
                newName: "IX_GruposFamiliares_SocialStudyId");

            migrationBuilder.RenameIndex(
                name: "IX_EstudioSocial_DatosPersonaMenorId",
                table: "EstudiosSociales",
                newName: "IX_EstudiosSociales_DatosPersonaMenorId");

            migrationBuilder.RenameIndex(
                name: "IX_EstudioSocial_DatosEncargadoId",
                table: "EstudiosSociales",
                newName: "IX_EstudiosSociales_DatosEncargadoId");

            migrationBuilder.RenameIndex(
                name: "IX_EstudioSocial_DatosAcompannanteId",
                table: "EstudiosSociales",
                newName: "IX_EstudiosSociales_DatosAcompannanteId");

            migrationBuilder.AddColumn<DateTime>(
                name: "ActualizadoEn",
                table: "Huespedes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreadoEn",
                table: "Huespedes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_GruposFamiliares",
                table: "GruposFamiliares",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstudiosSociales",
                table: "EstudiosSociales",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DatosPersonasMenores",
                table: "DatosPersonasMenores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DatosEncargados",
                table: "DatosEncargados",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DatosAcompannantes",
                table: "DatosAcompannantes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Aportes_EstudiosSociales_SocialStudyId",
                table: "Aportes",
                column: "SocialStudyId",
                principalTable: "EstudiosSociales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_GruposFamiliares_EstudiosSociales_SocialStudyId",
                table: "GruposFamiliares",
                column: "SocialStudyId",
                principalTable: "EstudiosSociales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Huespedes_EstudiosSociales_EstudioSocialId",
                table: "Huespedes",
                column: "EstudioSocialId",
                principalTable: "EstudiosSociales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aportes_EstudiosSociales_SocialStudyId",
                table: "Aportes");

            migrationBuilder.DropForeignKey(
                name: "FK_EstudiosSociales_DatosAcompannantes_DatosAcompannanteId",
                table: "EstudiosSociales");

            migrationBuilder.DropForeignKey(
                name: "FK_EstudiosSociales_DatosEncargados_DatosEncargadoId",
                table: "EstudiosSociales");

            migrationBuilder.DropForeignKey(
                name: "FK_EstudiosSociales_DatosPersonasMenores_DatosPersonaMenorId",
                table: "EstudiosSociales");

            migrationBuilder.DropForeignKey(
                name: "FK_GruposFamiliares_EstudiosSociales_SocialStudyId",
                table: "GruposFamiliares");

            migrationBuilder.DropForeignKey(
                name: "FK_Huespedes_EstudiosSociales_EstudioSocialId",
                table: "Huespedes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GruposFamiliares",
                table: "GruposFamiliares");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstudiosSociales",
                table: "EstudiosSociales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DatosPersonasMenores",
                table: "DatosPersonasMenores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DatosEncargados",
                table: "DatosEncargados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DatosAcompannantes",
                table: "DatosAcompannantes");

            migrationBuilder.DropColumn(
                name: "ActualizadoEn",
                table: "Huespedes");

            migrationBuilder.DropColumn(
                name: "CreadoEn",
                table: "Huespedes");

            migrationBuilder.RenameTable(
                name: "GruposFamiliares",
                newName: "GrupoFamiliar");

            migrationBuilder.RenameTable(
                name: "EstudiosSociales",
                newName: "EstudioSocial");

            migrationBuilder.RenameTable(
                name: "DatosPersonasMenores",
                newName: "DatosPersonaMenor");

            migrationBuilder.RenameTable(
                name: "DatosEncargados",
                newName: "DatosEncargado");

            migrationBuilder.RenameTable(
                name: "DatosAcompannantes",
                newName: "DatosAcompannante");

            migrationBuilder.RenameIndex(
                name: "IX_GruposFamiliares_SocialStudyId",
                table: "GrupoFamiliar",
                newName: "IX_GrupoFamiliar_SocialStudyId");

            migrationBuilder.RenameIndex(
                name: "IX_EstudiosSociales_DatosPersonaMenorId",
                table: "EstudioSocial",
                newName: "IX_EstudioSocial_DatosPersonaMenorId");

            migrationBuilder.RenameIndex(
                name: "IX_EstudiosSociales_DatosEncargadoId",
                table: "EstudioSocial",
                newName: "IX_EstudioSocial_DatosEncargadoId");

            migrationBuilder.RenameIndex(
                name: "IX_EstudiosSociales_DatosAcompannanteId",
                table: "EstudioSocial",
                newName: "IX_EstudioSocial_DatosAcompannanteId");

            migrationBuilder.AlterColumn<int>(
                name: "DatosPersonaMenorId",
                table: "EstudioSocial",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DatosEncargadoId",
                table: "EstudioSocial",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DatosAcompannanteId",
                table: "EstudioSocial",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GrupoFamiliar",
                table: "GrupoFamiliar",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstudioSocial",
                table: "EstudioSocial",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DatosPersonaMenor",
                table: "DatosPersonaMenor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DatosEncargado",
                table: "DatosEncargado",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DatosAcompannante",
                table: "DatosAcompannante",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Aportes_EstudioSocial_SocialStudyId",
                table: "Aportes",
                column: "SocialStudyId",
                principalTable: "EstudioSocial",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EstudioSocial_DatosAcompannante_DatosAcompannanteId",
                table: "EstudioSocial",
                column: "DatosAcompannanteId",
                principalTable: "DatosAcompannante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EstudioSocial_DatosEncargado_DatosEncargadoId",
                table: "EstudioSocial",
                column: "DatosEncargadoId",
                principalTable: "DatosEncargado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EstudioSocial_DatosPersonaMenor_DatosPersonaMenorId",
                table: "EstudioSocial",
                column: "DatosPersonaMenorId",
                principalTable: "DatosPersonaMenor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GrupoFamiliar_EstudioSocial_SocialStudyId",
                table: "GrupoFamiliar",
                column: "SocialStudyId",
                principalTable: "EstudioSocial",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Huespedes_EstudioSocial_EstudioSocialId",
                table: "Huespedes",
                column: "EstudioSocialId",
                principalTable: "EstudioSocial",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
