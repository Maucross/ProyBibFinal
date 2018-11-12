using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BIBLIOTECA.Models;
using ProyBibFinalCopia.Models;

namespace BIBLIOTECA.Models
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext (DbContextOptions<BibliotecaContext> options) : base (options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

             modelBuilder.Entity<Categoria>().HasData(
                new Categoria {
                    Id = 1,
                    Nombre = "Sistemas"
                    
                },
                new Categoria {
                    Id = 2,
                    Nombre = "Arquitectura"
                   
                },
                new Categoria {
                    Id = 3,
                    Nombre = "Industrial"
                },
                new Categoria {
                    Id = 4,
                    Nombre = "Matematica"
                }
            );

            base.OnModelCreating(modelBuilder);

             modelBuilder.Entity<Modalidad>().HasData(
                new Modalidad {
                    Id = 1,
                    Nombre = "A domicilio(max 2 dias)"
                    
                },
                new Modalidad {
                    Id = 2,
                    Nombre = "A sala (hasta que cierre la biblioteca)"
                   
                }
            );
        }
        public DbSet<Bibliotecario> bibliotecarios {get; set;}
        public DbSet<Estudiante> Estudiantes {get; set;}
        public DbSet<Libro> Libros {get; set;}
        public DbSet<Prestamo> Prestamos {get; set;}
        public DbSet<Categoria> Categorias {get; set;}
        public DbSet<Modalidad> Modalidades {get; set;}
    }
}