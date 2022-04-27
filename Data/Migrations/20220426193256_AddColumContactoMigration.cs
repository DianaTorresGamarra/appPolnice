using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appPolnice.Migrations
{
    public partial class AddColumContactoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "email",
                table: "t_contacto",
                newName: "name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "t_contacto",
                newName: "email");
        }
    }
}
