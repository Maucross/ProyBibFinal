using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BIBLIOTECA.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bibliotecario",
                columns: table => new
                {
                    id_bib = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    usuario = table.Column<string>(nullable: false),
                    contraseña = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bibliotecario", x => x.id_bib);
                });

            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    cod_est = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    usuario = table.Column<string>(nullable: false),
                    contraseña = table.Column<string>(nullable: false),
                    nomb = table.Column<string>(nullable: true),
                    ape = table.Column<string>(nullable: true),
                    escuela = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.cod_est);
                });

            migrationBuilder.CreateTable(
                name: "Libro",
                columns: table => new
                {
                    cod_lib = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ISBN = table.Column<string>(nullable: false),
                    categoriaId = table.Column<int>(nullable: true),
                    titulo = table.Column<string>(nullable: false),
                    autor = table.Column<string>(nullable: false),
                    editorial = table.Column<string>(nullable: false),
                    año_pub = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libro", x => x.cod_lib);
                    table.ForeignKey(
                        name: "FK_Libro_categorias_categoriaId",
                        column: x => x.categoriaId,
                        principalTable: "categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prestamo",
                columns: table => new
                {
                    cod_prest = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    datosLibrocod_lib = table.Column<int>(nullable: true),
                    datosEstudiantecod_est = table.Column<int>(nullable: true),
                    modalidad = table.Column<string>(nullable: false),
                    fecha_reserva = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamo", x => x.cod_prest);
                    table.ForeignKey(
                        name: "FK_Prestamo_Estudiante_datosEstudiantecod_est",
                        column: x => x.datosEstudiantecod_est,
                        principalTable: "Estudiante",
                        principalColumn: "cod_est",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prestamo_Libro_datosLibrocod_lib",
                        column: x => x.datosLibrocod_lib,
                        principalTable: "Libro",
                        principalColumn: "cod_lib",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "categorias",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Sistemas" },
                    { 2, "Arquitectura" },
                    { 3, "Industrial" },
                    { 4, "Matematica" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libro_categoriaId",
                table: "Libro",
                column: "categoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_datosEstudiantecod_est",
                table: "Prestamo",
                column: "datosEstudiantecod_est");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_datosLibrocod_lib",
                table: "Prestamo",
                column: "datosLibrocod_lib");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bibliotecario");

            migrationBuilder.DropTable(
                name: "Prestamo");

            migrationBuilder.DropTable(
                name: "Estudiante");

            migrationBuilder.DropTable(
                name: "Libro");

            migrationBuilder.DropTable(
                name: "categorias");
        }
    }
}
