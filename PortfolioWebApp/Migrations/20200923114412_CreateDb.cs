using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortfolioWebApp.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contact",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Mail = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Facebook = table.Column<string>(nullable: false),
                    Twitter = table.Column<string>(nullable: false),
                    Instagram = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Picture = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "photographer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(nullable: false),
                    dateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photographer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "photo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    DataFile = table.Column<byte[]>(nullable: true),
                    photographerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_photo_photographer_photographerId",
                        column: x => x.photographerId,
                        principalTable: "photographer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "Description", "Name", "Picture" },
                values: new object[] { new Guid("5d06fd09-452a-453b-a134-3c64af690bec"), "Photographer and Designer", "MohaNed Ghawar", null });

            migrationBuilder.InsertData(
                table: "contact",
                columns: new[] { "Id", "Facebook", "Instagram", "Mail", "Phone", "Twitter" },
                values: new object[] { new Guid("4c38abb5-885e-444e-b974-215deaa12d3d"), "MohaNed Facebook", "MohaNed Instagram", "MohaNed@Gmail.com", "002191234567888", "MohaNed Twitter" });

            migrationBuilder.CreateIndex(
                name: "IX_photo_photographerId",
                table: "photo",
                column: "photographerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contact");

            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.DropTable(
                name: "photo");

            migrationBuilder.DropTable(
                name: "photographer");
        }
    }
}
