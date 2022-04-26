using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appPolnice.Migrations
{
    public partial class AddColumContactMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "t_producto",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "t_producto",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "t_producto");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "t_producto");
        }
    }
}
