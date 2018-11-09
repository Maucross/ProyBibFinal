using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BIBLIOTECA.Models;
namespace ProyBibFinalCopia.Controllers
{
    public class LibroController : Controller
    {
        private readonly BibliotecaContext _context;

        public LibroController(BibliotecaContext context)
        {
            _context = context;
        }
        //pagina donde agarra los datos GET
        public async Task<IActionResult> Libros()
        {
            return View(await _context.Libros.ToListAsync());
        }
        //PARA BOTON DETALLES
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var libro = await _context.Libros
                .SingleOrDefaultAsync(m => m.cod_lib == id);
            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }
        //DONDE SE INGRESAN LOS DATOS (REGISTRARLIBRO)
        public IActionResult RegistrarLibro()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegistrarLibro([Bind("cod_lib,ISBN,titulo,autor,editorial,año_pub")] Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(libro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(libro));
            }
            return View(libro);
        }    

        //PARA BOTON DE MODIFICAR 1
         public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var libro = await _context.Libros.SingleOrDefaultAsync(m => m.cod_lib == id);
            if (libro == null)
            {
                return NotFound();
            }
            return View(libro);
        }
        //PARA BOTON DE MODIFICAR 2

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ISBN,titulo,titulo,autor,editorial")] Libro libro)
        {
            if (id != libro.cod_lib)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(libro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LibroExists(libro.cod_lib))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Libros));
            }
            return View(libro);
        }
        //BOTON PARA ELIMINAR

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var libro = await _context.Libros
                .SingleOrDefaultAsync(m => m.cod_lib == id);
            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var libro = await _context.Libros.SingleOrDefaultAsync(m => m.cod_lib == id);
            _context.Libros.Remove(libro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(DeleteConfirmed));
        }
        private bool LibroExists(int id)
        {
            return _context.Libros.Any(e => e.cod_lib == id);
        }

        public IActionResult DeleteConfirmed()
        {
            return View();
        }

    }
}