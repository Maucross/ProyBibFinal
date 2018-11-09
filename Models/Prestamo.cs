using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProyBibFinalCopia.Models;

namespace BIBLIOTECA.Models
{
    public class Prestamo
    {
        [Key]
        public int cod_prest {get; set;}
        public Libro Libro {get; set;}
        public Estudiante Estudiante {get; set;}
        [Required(ErrorMessage = "Ingresar modalidad")]
        public Modalidad Modalidad {get; set;}
        public int? ModalidadId {get; set;}
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fecha_reserva {get; set;}
       
    }
}
