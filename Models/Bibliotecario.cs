using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BIBLIOTECA.Models
{
    public class Bibliotecario
    {
        
        //public int tipoU {get; set;} //tipo1 = bibliotecario, tipo2 = estudiante 
        [Key]
        public int id_bib {get; set;}
        [EmailAddress]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Error en el usuario o contrasena")]
        public string usuario {get; set;}
        
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Error en el usuario o contrasena")]
        public string contraseña {get; set;}
    }
}
