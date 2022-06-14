using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookTracker.Migrations
{
    public partial class updateRegisterModelToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "Register");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "Register",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
