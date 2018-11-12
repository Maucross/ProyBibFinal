using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BIBLIOTECA.Models
{
    public class Categoria
    {
        //Id
        public int Id {get; set;}
<<<<<<< HEAD
        [Required]
=======
        //Nombre
>>>>>>> c1048ceec744d40708034c5525550f9257b52fc6
        public string Nombre {get; set;}
        public List<Libro> Libros {get; set;}
        
        //Categoría
        public Categoria() {
            Libros = new List<Libro>();
        }
    }
}
