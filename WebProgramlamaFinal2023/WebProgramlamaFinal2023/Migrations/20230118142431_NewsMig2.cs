using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProgramlamaFinal2023.Migrations
{
    public partial class NewsMig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "News");

            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "News");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "News",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
