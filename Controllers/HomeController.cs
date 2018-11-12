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
<<<<<<< HEAD

        
        public IActionResult BuscarCatalogo(string buscar) {
            var libros = _context.Libros.Include(l => l.Categoria).AsQueryable();

            if(!string.IsNullOrEmpty(buscar))
            {
                libros = libros.Where(l => l.ISBN.Contains(buscar)||l.titulo.Contains(buscar) 
                ||l.Categoria.Nombre.Contains(buscar) || l.autor.Contains(buscar)|| l.editorial.Contains(buscar));
            }

            ViewBag.buscar = buscar;
            return View(libros.OrderBy(l => l.titulo).ToList());
        }
        public IActionResult RegistrarLibro(){
            PreCargaDatos();
            return View();
        }
=======
        
>>>>>>> c1048ceec744d40708034c5525550f9257b52fc6
        
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

        #region prestamo
         public IActionResult VerPrestamo(string buscar) {
            var prestamo = _context.Prestamos.Include(p => p.Modalidad).AsQueryable();

            if(!string.IsNullOrEmpty(buscar))
            {
                prestamo = prestamo.Where(p => p.Libro.titulo.Contains(buscar)||p.Estudiante.nomb.Contains(buscar) 
                ||p.Modalidad.Nombre.Contains(buscar));
            }

            ViewBag.buscar = buscar;
            return View(prestamo.OrderBy(p => p.cod_prest).ToList());
        }
        public IActionResult GenerarPrestamo(){
            PreCargaDatos2();
            return View();
        }
        public void PreCargaDatos2() {
            ViewBag.Modalidades = new SelectList(_context.Modalidades, "Id","Nombre");
        }

        [HttpPost]
         public IActionResult GenerarPrestamo(Prestamo p)
        {
             if (ModelState.IsValid)
            {
                _context.Add(p);
                _context.SaveChanges();

                return RedirectToAction("GenerarPrestamo");
            }
            PreCargaDatos2();

            return View(p);
        } 
        #endregion
         public IActionResult DetalleLib()
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