using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BIBLIOTECA.Models
{
    public class categoria
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public List<Libro> Libros {get; set;}

        public categoria() {
            Libros = new List<Libro>();
        }
    }
}