using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthService.Migrations
{
    public partial class Changing_Table_Names : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "TBL_USER_TOKEN");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "TBL_USERS");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "TBL_USER_ROLE");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "TBL_USER_LOGIN");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "TBL_USER_CLAIM");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "TBL_ROLES");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "TBL_ROLE_CLAIM");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "TBL_USER_ROLE",
                newName: "IX_TBL_USER_ROLE_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "TBL_USER_LOGIN",
                newName: "IX_TBL_USER_LOGIN_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "TBL_USER_CLAIM",
                newName: "IX_TBL_USER_CLAIM_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "TBL_ROLE_CLAIM",
                newName: "IX_TBL_ROLE_CLAIM_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_USER_TOKEN",
                table: "TBL_USER_TOKEN",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_USERS",
                table: "TBL_USERS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_USER_ROLE",
                table: "TBL_USER_ROLE",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_USER_LOGIN",
                table: "TBL_USER_LOGIN",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_USER_CLAIM",
                table: "TBL_USER_CLAIM",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_ROLES",
                table: "TBL_ROLES",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_ROLE_CLAIM",
                table: "TBL_ROLE_CLAIM",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_ROLE_CLAIM_TBL_ROLES_RoleId",
                table: "TBL_ROLE_CLAIM",
                column: "RoleId",
                principalTable: "TBL_ROLES",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_USER_CLAIM_TBL_USERS_UserId",
                table: "TBL_USER_CLAIM",
                column: "UserId",
                principalTable: "TBL_USERS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_USER_LOGIN_TBL_USERS_UserId",
                table: "TBL_USER_LOGIN",
                column: "UserId",
                principalTable: "TBL_USERS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_USER_ROLE_TBL_ROLES_RoleId",
                table: "TBL_USER_ROLE",
                column: "RoleId",
                principalTable: "TBL_ROLES",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_USER_ROLE_TBL_USERS_UserId",
                table: "TBL_USER_ROLE",
                column: "UserId",
                principalTable: "TBL_USERS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_USER_TOKEN_TBL_USERS_UserId",
                table: "TBL_USER_TOKEN",
                column: "UserId",
                principalTable: "TBL_USERS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_ROLE_CLAIM_TBL_ROLES_RoleId",
                table: "TBL_ROLE_CLAIM");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_USER_CLAIM_TBL_USERS_UserId",
                table: "TBL_USER_CLAIM");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_USER_LOGIN_TBL_USERS_UserId",
                table: "TBL_USER_LOGIN");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_USER_ROLE_TBL_ROLES_RoleId",
                table: "TBL_USER_ROLE");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_USER_ROLE_TBL_USERS_UserId",
                table: "TBL_USER_ROLE");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_USER_TOKEN_TBL_USERS_UserId",
                table: "TBL_USER_TOKEN");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_USERS",
                table: "TBL_USERS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_USER_TOKEN",
                table: "TBL_USER_TOKEN");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_USER_ROLE",
                table: "TBL_USER_ROLE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_USER_LOGIN",
                table: "TBL_USER_LOGIN");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_USER_CLAIM",
                table: "TBL_USER_CLAIM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_ROLES",
                table: "TBL_ROLES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_ROLE_CLAIM",
                table: "TBL_ROLE_CLAIM");

            migrationBuilder.RenameTable(
                name: "TBL_USERS",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "TBL_USER_TOKEN",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "TBL_USER_ROLE",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "TBL_USER_LOGIN",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "TBL_USER_CLAIM",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "TBL_ROLES",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "TBL_ROLE_CLAIM",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_USER_ROLE_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_USER_LOGIN_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_USER_CLAIM_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_ROLE_CLAIM_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
