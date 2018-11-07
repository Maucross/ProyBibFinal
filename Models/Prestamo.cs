using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BIBLIOTECA.Models
{
    public class Prestamo
    {
        [Key]
        public int cod_prest {get; set;}
        public Libro datosLibro {get; set;}
        public Estudiante datosEstudiante {get; set;}
        [Required(ErrorMessage = "Ingresar modalidad")]
        public string modalidad {get; set;}
        [Required(ErrorMessage = "Ingresar fecha de reserva")]
        public DateTime fecha_reserva {get; set;}
       
    }
}
