using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BIBLIOTECA.Models
{
    public class Categoria
    {
        //Id
        public int Id {get; set;}
        //Nombre
        public string Nombre {get; set;}
        public List<Libro> Libros {get; set;}

        public Categoria() {
            Libros = new List<Libro>();
        }
    }
}
