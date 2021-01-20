using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication6.Migrations
{
    public partial class FIIl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "gFirstModID",
                table: "Students",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "gSecondModID",
                table: "Students",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Firs_tMod",
                columns: table => new
                {
                    gId = table.Column<Guid>(nullable: false),
                    szNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firs_tMod", x => x.gId);
                });

            migrationBuilder.CreateTable(
                name: "SecondMod",
                columns: table => new
                {
                    gId = table.Column<Guid>(nullable: false),
                    szNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondMod", x => x.gId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Firs_tMod");

            migrationBuilder.DropTable(
                name: "SecondMod");

            migrationBuilder.DropColumn(
                name: "gFirstModID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "gSecondModID",
                table: "Students");
        }
    }
}
