using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appPolnice.Data.Migrations
{
    public partial class ContactoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Comentario",
                table: "t_contacto",
                newName: "Mensaje");

            migrationBuilder.AddColumn<string>(
                name: "Correo",
                table: "t_contacto",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Correo",
                table: "t_contacto");

            migrationBuilder.RenameColumn(
                name: "Mensaje",
                table: "t_contacto",
                newName: "Comentario");
        }
    }
}
