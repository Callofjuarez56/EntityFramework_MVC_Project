using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication6.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) // Миграция создает команды для изменения БД
        {
            migrationBuilder.CreateTable(
                name: "tblGroup",
                columns: table => new
                {
                    gId = table.Column<Guid>(nullable: false),
                    szName = table.Column<string>(nullable: false),
                    szDepartmentnumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblGroup", x => x.gId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    gId = table.Column<Guid>(nullable: false),
                    szNumb_1 = table.Column<double>(maxLength: 50, nullable: false),
                    szNumb_2 = table.Column<double>(maxLength: 50, nullable: false),
                    gGroupID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.gId);
                    table.ForeignKey(
                        name: "FK_Students_tblGroup_gGroupID",
                        column: x => x.gGroupID,
                        principalTable: "tblGroup",
                        principalColumn: "gId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_gGroupID",
                table: "Students",
                column: "gGroupID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "tblGroup");
        }
    }
}
