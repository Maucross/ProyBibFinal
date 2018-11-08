using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BIBLIOTECA.Models;

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
        }
        public DbSet<Bibliotecario> bibliotecarios {get; set;}
        public DbSet<Estudiante> Estudiantes {get; set;}
        public DbSet<Libro> Libros {get; set;}
        public DbSet<Prestamo> Prestamos {get; set;}
        public DbSet<Categoria> Categorias {get; set;}
    }
}