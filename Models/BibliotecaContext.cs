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

             modelBuilder.Entity<categoria>().HasData(
                new categoria {
                    Id = 1,
                    Nombre = "Sistemas"
                    
                },
                new categoria {
                    Id = 2,
                    Nombre = "Arquitectura"
                   
                },
                new categoria {
                    Id = 3,
                    Nombre = "Industrial"
                },
                new categoria {
                    Id = 4,
                    Nombre = "Matematica"
                }
            );
        }
        public DbSet<Bibliotecario> Bibliotecario {get; set;}
        public DbSet<Estudiante> Estudiante {get; set;}
        public DbSet<Libro> Libro {get; set;}
        public DbSet<Prestamo> Prestamo {get; set;}
        public DbSet<categoria> categorias {get; set;}
    }
}