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
<<<<<<< HEAD
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
=======
        //DatosLibro
        public Libro datosLibro {get; set;}
        //DatosEstudiante
        public Estudiante datosEstudiante {get; set;}
        [Required(ErrorMessage = "Ingresar modalidad")]
        //Modalidad
        public string modalidad {get; set;}
        [Required(ErrorMessage = "Ingresar fecha de reserva")]
>>>>>>> c1048ceec744d40708034c5525550f9257b52fc6
        public DateTime fecha_reserva {get; set;}
       
    }
}
