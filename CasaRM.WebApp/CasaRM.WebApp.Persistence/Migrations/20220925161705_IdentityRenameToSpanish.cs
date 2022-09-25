using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasaRM.WebApp.Persistence.Migrations
{
    public partial class IdentityRenameToSpanish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_Users_UserId",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_Users_UserId",
                table: "UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTokens_Users_UserId",
                table: "UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTokens",
                table: "UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                newName: "TokensUsuario");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "RolesUsuario");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                newName: "LoginsUsuario");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                newName: "ClaimsUsuario");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                newName: "ClaimsRoles");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_RoleId",
                table: "RolesUsuario",
                newName: "IX_RolesUsuario_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_UserId",
                table: "LoginsUsuario",
                newName: "IX_LoginsUsuario_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserClaims_UserId",
                table: "ClaimsUsuario",
                newName: "IX_ClaimsUsuario_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_RoleId",
                table: "ClaimsRoles",
                newName: "IX_ClaimsRoles_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TokensUsuario",
                table: "TokensUsuario",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RolesUsuario",
                table: "RolesUsuario",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoginsUsuario",
                table: "LoginsUsuario",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClaimsUsuario",
                table: "ClaimsUsuario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClaimsRoles",
                table: "ClaimsRoles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClaimsRoles_Roles_RoleId",
                table: "ClaimsRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClaimsUsuario_Usuarios_UserId",
                table: "ClaimsUsuario",
                column: "UserId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoginsUsuario_Usuarios_UserId",
                table: "LoginsUsuario",
                column: "UserId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolesUsuario_Roles_RoleId",
                table: "RolesUsuario",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolesUsuario_Usuarios_UserId",
                table: "RolesUsuario",
                column: "UserId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TokensUsuario_Usuarios_UserId",
                table: "TokensUsuario",
                column: "UserId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClaimsRoles_Roles_RoleId",
                table: "ClaimsRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_ClaimsUsuario_Usuarios_UserId",
                table: "ClaimsUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_LoginsUsuario_Usuarios_UserId",
                table: "LoginsUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_RolesUsuario_Roles_RoleId",
                table: "RolesUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_RolesUsuario_Usuarios_UserId",
                table: "RolesUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_TokensUsuario_Usuarios_UserId",
                table: "TokensUsuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TokensUsuario",
                table: "TokensUsuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RolesUsuario",
                table: "RolesUsuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoginsUsuario",
                table: "LoginsUsuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClaimsUsuario",
                table: "ClaimsUsuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClaimsRoles",
                table: "ClaimsRoles");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "TokensUsuario",
                newName: "UserTokens");

            migrationBuilder.RenameTable(
                name: "RolesUsuario",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "LoginsUsuario",
                newName: "UserLogins");

            migrationBuilder.RenameTable(
                name: "ClaimsUsuario",
                newName: "UserClaims");

            migrationBuilder.RenameTable(
                name: "ClaimsRoles",
                newName: "RoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_RolesUsuario_RoleId",
                table: "UserRoles",
                newName: "IX_UserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_LoginsUsuario_UserId",
                table: "UserLogins",
                newName: "IX_UserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ClaimsUsuario_UserId",
                table: "UserClaims",
                newName: "IX_UserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ClaimsRoles_RoleId",
                table: "RoleClaims",
                newName: "IX_RoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTokens",
                table: "UserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                table: "RoleClaims",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_Users_UserId",
                table: "UserClaims",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_Users_UserId",
                table: "UserLogins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTokens_Users_UserId",
                table: "UserTokens",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
