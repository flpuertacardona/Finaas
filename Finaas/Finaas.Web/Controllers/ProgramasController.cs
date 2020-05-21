using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Finaas.Web.Data.Investigacion;

namespace Finaas.Web.Controllers
{
    public class ProgramasController : Controller
    {
        private readonly InvestigacionContext _context;

        public ProgramasController(InvestigacionContext context)
        {
            _context = context;
        }

        // GET: Programas
        public async Task<IActionResult> Index()
        {
            var investigacionContext = _context.Programas.Include(p => p.Escuela);
            return View(await investigacionContext.ToListAsync());
        }

        // GET: Programas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programa = await _context.Programas
                .Include(p => p.Escuela)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (programa == null)
            {
                return NotFound();
            }

            return View(programa);
        }

        // GET: Programas/Create
        public IActionResult Create()
        {
            ViewData["EscuelaId"] = new SelectList(_context.Escuelas, "Id", "Id");
            return View();
        }

        // POST: Programas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Categoria,EscuelaId")] Programa programa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(programa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EscuelaId"] = new SelectList(_context.Escuelas, "Id", "Id", programa.EscuelaId);
            return View(programa);
        }

        // GET: Programas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programa = await _context.Programas.FindAsync(id);
            if (programa == null)
            {
                return NotFound();
            }
            ViewData["EscuelaId"] = new SelectList(_context.Escuelas, "Id", "Id", programa.EscuelaId);
            return View(programa);
        }

        // POST: Programas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Categoria,EscuelaId")] Programa programa)
        {
            if (id != programa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(programa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgramaExists(programa.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EscuelaId"] = new SelectList(_context.Escuelas, "Id", "Id", programa.EscuelaId);
            return View(programa);
        }

        // GET: Programas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programa = await _context.Programas
                .Include(p => p.Escuela)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (programa == null)
            {
                return NotFound();
            }

            return View(programa);
        }

        // POST: Programas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var programa = await _context.Programas.FindAsync(id);
            _context.Programas.Remove(programa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProgramaExists(int id)
        {
            return _context.Programas.Any(e => e.Id == id);
        }
    }
}
