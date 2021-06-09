using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SealSearch.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CandidateList",
                columns: table => new
                {
                    userName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dob = table.Column<int>(type: "int", nullable: false),
                    phoneNumber = table.Column<int>(type: "int", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateList", x => x.userName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateList");
        }
    }
}
