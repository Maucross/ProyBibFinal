using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BIBLIOTECA.Models
{
    public class Estudiante
    {
        //public int tipoU {get; set;} //tipo1 = bibliotecario, tipo2 = estudiante 
        [Key]
        public int cod_est{get; set;}
<<<<<<< HEAD
=======

        [Required(ErrorMessage = "Error en el usuario o contrasena")]
        public string usuario {get; set;}

        [Required(ErrorMessage = "Error en el usuario o contrasena")]
        public string contraseña {get; set;}
        
        //Nombre
>>>>>>> c1048ceec744d40708034c5525550f9257b52fc6
        public string nomb {get; set;}
        //Apellido
        public string ape {get; set;}
        //Escuela
        public string escuela {get; set;}
    }
}
