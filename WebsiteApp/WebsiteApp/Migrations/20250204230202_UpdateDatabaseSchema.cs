using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsiteApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabaseSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CLubs_Addresses_AddressId",
                table: "CLubs");

            migrationBuilder.DropForeignKey(
                name: "FK_CLubs_AppUser_AppUserId",
                table: "CLubs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CLubs",
                table: "CLubs");

            migrationBuilder.RenameTable(
                name: "CLubs",
                newName: "Clubs");

            migrationBuilder.RenameIndex(
                name: "IX_CLubs_AppUserId",
                table: "Clubs",
                newName: "IX_Clubs_AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_CLubs_AddressId",
                table: "Clubs",
                newName: "IX_Clubs_AddressId");

            migrationBuilder.AddColumn<int>(
                name: "RaceCategory",
                table: "Races",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clubs",
                table: "Clubs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Addresses_AddressId",
                table: "Clubs",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_AppUser_AppUserId",
                table: "Clubs",
                column: "AppUserId",
                principalTable: "AppUser",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Addresses_AddressId",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_AppUser_AppUserId",
                table: "Clubs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clubs",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "RaceCategory",
                table: "Races");

            migrationBuilder.RenameTable(
                name: "Clubs",
                newName: "CLubs");

            migrationBuilder.RenameIndex(
                name: "IX_Clubs_AppUserId",
                table: "CLubs",
                newName: "IX_CLubs_AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Clubs_AddressId",
                table: "CLubs",
                newName: "IX_CLubs_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CLubs",
                table: "CLubs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CLubs_Addresses_AddressId",
                table: "CLubs",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CLubs_AppUser_AppUserId",
                table: "CLubs",
                column: "AppUserId",
                principalTable: "AppUser",
                principalColumn: "Id");
        }
    }
}
