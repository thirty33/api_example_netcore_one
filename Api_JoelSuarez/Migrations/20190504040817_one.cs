using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Api_JoelSuarez.Migrations
{
    public partial class one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "person",
                columns: table => new
                {
                    name = table.Column<string>(nullable: false),
                    last_name = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    Creation_Date = table.Column<TimeSpan>(nullable: false),
                    creation_information = table.Column<DateTime>(nullable: false),
                    isActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "itemProject",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    Creation_Date = table.Column<TimeSpan>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itemProject", x => x.id);
                    table.ForeignKey(
                        name: "FK_itemProject_person_name",
                        column: x => x.name,
                        principalTable: "person",
                        principalColumn: "name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectItemTwo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    Creation_Date = table.Column<TimeSpan>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    Owner = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectItemTwo", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProjectItemTwo_person_Owner",
                        column: x => x.Owner,
                        principalTable: "person",
                        principalColumn: "name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_itemProject_name",
                table: "itemProject",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectItemTwo_Owner",
                table: "ProjectItemTwo",
                column: "Owner");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "itemProject");

            migrationBuilder.DropTable(
                name: "ProjectItemTwo");

            migrationBuilder.DropTable(
                name: "person");
        }
    }
}
