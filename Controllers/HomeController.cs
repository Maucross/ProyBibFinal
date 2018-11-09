using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BIBLIOTECA.Models;

namespace BIBLIOTECA.Controllers
{
    public class HomeController : Controller
    {
        private readonly BibliotecaContext _context;
        public HomeController (BibliotecaContext _context)
        {
            this._context = _context;
        }
        //Login
         public IActionResult Login()
        {
            ViewData["Message"] = "Your login page.";

            return View();
        }
        //RecuperarContraseña
         public IActionResult RecuperarContraseña()
        {
            ViewData["Message"] = "Your password page.";

            return View();
        }
        //Menú
        public IActionResult Menu()
        {
            ViewData["Message"] = "Menu";

            return View();
        }
         public IActionResult GenerarPrestamo()
        {
            ViewData["Message"] = "Your Prestamo page.";

            return View();
        }
        #region Libros
        public IActionResult Libros(string buscar) {
            var libros = _context.Libros.Include(l => l.Categoria).AsQueryable();

            if(!string.IsNullOrEmpty(buscar))
            {
                libros = libros.Where(l => l.ISBN.Contains(buscar)||l.titulo.Contains(buscar) 
                ||l.Categoria.Nombre.Contains(buscar) || l.autor.Contains(buscar)|| l.editorial.Contains(buscar));
            }

            ViewBag.buscar = buscar;
            return View(libros.OrderBy(l => l.titulo).ToList());
        }
        
        
        public void PreCargaDatos() {
            ViewBag.Categorias = new SelectList(_context.Categorias, "Id","Nombre");
        }

        [HttpPost]
        public IActionResult RegistrarLibro(Libro l){
            if (ModelState.IsValid)
            {
                _context.Add(l);
                _context.SaveChanges();

                return RedirectToAction("ConfirmaciónLibros");
            }
            PreCargaDatos();

            return View(l);
        }
        public IActionResult ConfirmaciónLibros(){
            return View();
        }

        #endregion
        public IActionResult VerPrestamo()
        {
            
            return View();
        }
         public IActionResult DetalleLib()
        {
            return View();
        }
         public IActionResult BuscarCatalogo()
        {
            return View();
        }
         public IActionResult InfoLibro()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
