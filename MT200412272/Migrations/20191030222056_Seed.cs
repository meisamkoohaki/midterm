using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MT200412272.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forum",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    comment = table.Column<string>(maxLength: 500, nullable: true),
                    date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forum", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Forum",
                columns: new[] { "Id", "comment", "date", "name" },
                values: new object[] { 1, "It is a good webpage!", new DateTime(2010, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meisam" });

            migrationBuilder.InsertData(
                table: "Forum",
                columns: new[] { "Id", "comment", "date", "name" },
                values: new object[] { 2, "It is awsome!", new DateTime(2010, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Koohaki" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forum");
        }
    }
}
