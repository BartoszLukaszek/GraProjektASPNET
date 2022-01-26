using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gra_Projekt_ASP.NET.Migrations
{
    public partial class AddSignUpToDatabse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "SignUp",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "SignUp",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "SignUp",
                newName: "PlayerId");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "SignUp",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
