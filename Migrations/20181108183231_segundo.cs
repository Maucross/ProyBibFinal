using Microsoft.EntityFrameworkCore.Migrations;

namespace BIBLIOTECA.Migrations
{
    public partial class segundo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "Libros",
                maxLength: 17,
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "Libros",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 17);
        }
    }
}
