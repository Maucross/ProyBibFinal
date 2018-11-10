using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
namespace BIBLIOTECA.Models
{
    public class Libro
    {
        [Key]
        public int cod_lib {get; set;}
        [Required]
        public string ISBN {get; set;}
        public Categoria Categoria {get; set;}
        public int? CategoriaId {get; set;}

        
    }
}
