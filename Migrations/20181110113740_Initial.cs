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
                    Nombre = table.Column<string>(nullable: false)
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
                    nomb = table.Column<string>(nullable: true),
                    ape = table.Column<string>(nullable: true),
                    escuela = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.cod_est);
                });

            migrationBuilder.CreateTable(
                name: "Modalidades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modalidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    cod_lib = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ISBN = table.Column<string>(maxLength: 17, nullable: false),
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
                    Librocod_lib = table.Column<int>(nullable: true),
                    LibroISBN = table.Column<string>(nullable: true),
                    Librotitulo = table.Column<string>(nullable: true),
                    Libroautor = table.Column<string>(nullable: true),
                    Estudiantecod_est = table.Column<int>(nullable: true),
                    Estudiantenomb = table.Column<string>(nullable: true),
                    Estudianteape = table.Column<string>(nullable: true),
                    Estudianteescuela = table.Column<string>(nullable: true),
                    ModalidadId = table.Column<int>(nullable: false),
                    fecha_reserva = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.cod_prest);
                    table.ForeignKey(
                        name: "FK_Prestamos_Estudiantes_Estudiantecod_est",
                        column: x => x.Estudiantecod_est,
                        principalTable: "Estudiantes",
                        principalColumn: "cod_est",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prestamos_Libros_Librocod_lib",
                        column: x => x.Librocod_lib,
                        principalTable: "Libros",
                        principalColumn: "cod_lib",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prestamos_Modalidades_ModalidadId",
                        column: x => x.ModalidadId,
                        principalTable: "Modalidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "Modalidades",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "A domicilio(max 2 dias)" },
                    { 2, "A sala (hasta que cierre la biblioteca)" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libros_CategoriaId",
                table: "Libros",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_Estudiantecod_est",
                table: "Prestamos",
                column: "Estudiantecod_est");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_Librocod_lib",
                table: "Prestamos",
                column: "Librocod_lib");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_ModalidadId",
                table: "Prestamos",
                column: "ModalidadId");
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
                name: "Modalidades");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
