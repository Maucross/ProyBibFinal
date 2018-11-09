using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BIBLIOTECA.Models;

namespace ProyBibFinalCopia.Models
{
    public class Modalidad
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public List<Prestamo> Prestamo {get; set;}

        public Modalidad() {
            Prestamo = new List<Prestamo>();
        }
    }
}