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
        public int? Librocod_lib {get; set;}
        public string LibroISBN {get; set;}
        public string Librotitulo {get; set;}
        public string Libroautor {get; set;}
         
        public Estudiante Estudiante {get; set;}
        public int? Estudiantecod_est {get; set;}
        public string Estudiantenomb {get; set;}
        public string Estudianteape {get; set;}
        public string Estudianteescuela {get; set;}
        [Required(ErrorMessage = "Ingresar modalidad")]
        public Modalidad Modalidad {get; set;}
        public int? ModalidadId {get; set;}
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fecha_reserva {get; set;}
       
    }
}
