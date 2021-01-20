using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication6.Migrations
{
    public partial class RUBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "szNumb_2",
                table: "Students",
                newName: "szLastName");

            migrationBuilder.RenameColumn(
                name: "szNumb_1",
                table: "Students",
                newName: "szName");

            migrationBuilder.AddColumn<double>(
                name: "szGroupLeader",
                table: "Students",
                maxLength: 50,
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "szGroupLeader",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "szLastName",
                table: "Students",
                newName: "szNumb_2");

            migrationBuilder.RenameColumn(
                name: "szName",
                table: "Students",
                newName: "szNumb_1");
        }
    }
}
