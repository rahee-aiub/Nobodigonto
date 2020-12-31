using Microsoft.EntityFrameworkCore.Migrations;

namespace TestCoreApp.Migrations
{
    public partial class Addedforeignkeyformember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_members_AdminId",
                table: "members",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_members_Admins_AdminId",
                table: "members",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_members_Admins_AdminId",
                table: "members");

            migrationBuilder.DropIndex(
                name: "IX_members_AdminId",
                table: "members");
        }
    }
}
