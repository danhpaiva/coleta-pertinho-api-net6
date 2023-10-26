using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ColetaPertinhoAPI.Migrations
{
    public partial class SecondMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Ongs",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NomeResponsavel",
                table: "Ongs",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Ongs");

            migrationBuilder.DropColumn(
                name: "NomeResponsavel",
                table: "Ongs");
        }
    }
}
