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
                name: "bibliotecarios",
                columns: table => new
                {
                    id_bib = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    usuario = table.Column<string>(nullable: false),
                    contraseña = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bibliotecarios", x => x.id_bib);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
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
                    table.PrimaryKey("PK_Estudiantes", x => x.cod_est);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    cod_lib = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ISBN = table.Column<string>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: true),
                    titulo = table.Column<string>(nullable: false),
                    autor = table.Column<string>(nullable: false),
                    editorial = table.Column<string>(nullable: false),
                    año_pub = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.cod_lib);
                    table.ForeignKey(
                        name: "FK_Libros_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prestamos",
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
                    table.PrimaryKey("PK_Prestamos", x => x.cod_prest);
                    table.ForeignKey(
                        name: "FK_Prestamos_Estudiantes_datosEstudiantecod_est",
                        column: x => x.datosEstudiantecod_est,
                        principalTable: "Estudiantes",
                        principalColumn: "cod_est",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prestamos_Libros_datosLibrocod_lib",
                        column: x => x.datosLibrocod_lib,
                        principalTable: "Libros",
                        principalColumn: "cod_lib",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Sistemas" },
                    { 2, "Arquitectura" },
                    { 3, "Industrial" },
                    { 4, "Matematica" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libros_CategoriaId",
                table: "Libros",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_datosEstudiantecod_est",
                table: "Prestamos",
                column: "datosEstudiantecod_est");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_datosLibrocod_lib",
                table: "Prestamos",
                column: "datosLibrocod_lib");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bibliotecarios");

            migrationBuilder.DropTable(
                name: "Prestamos");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
