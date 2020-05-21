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
    public class FinanciacionesController : Controller
    {
        private readonly InvestigacionContext _context;

        public FinanciacionesController(InvestigacionContext context)
        {
            _context = context;
        }

        // GET: Financiaciones
        public async Task<IActionResult> Index()
        {
            var investigacionContext = _context.Financiaciones.Include(f => f.Ejecucion);
            return View(await investigacionContext.ToListAsync());
        }

        // GET: Financiaciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var financiacion = await _context.Financiaciones
                .Include(f => f.Ejecucion)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (financiacion == null)
            {
                return NotFound();
            }

            return View(financiacion);
        }

        // GET: Financiaciones/Create
        public IActionResult Create()
        {
            ViewData["EjecucionId"] = new SelectList(_context.Ejecuciones, "Id", "Id");
            return View();
        }

        // POST: Financiaciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,FuenteRecursos,CategoriasRecursos,FechaIngreso,Valor,Disponible,FechaDisponible,EjecucionId")] Financiacion financiacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(financiacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EjecucionId"] = new SelectList(_context.Ejecuciones, "Id", "Id", financiacion.EjecucionId);
            return View(financiacion);
        }

        // GET: Financiaciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var financiacion = await _context.Financiaciones.FindAsync(id);
            if (financiacion == null)
            {
                return NotFound();
            }
            ViewData["EjecucionId"] = new SelectList(_context.Ejecuciones, "Id", "Id", financiacion.EjecucionId);
            return View(financiacion);
        }

        // POST: Financiaciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,FuenteRecursos,CategoriasRecursos,FechaIngreso,Valor,Disponible,FechaDisponible,EjecucionId")] Financiacion financiacion)
        {
            if (id != financiacion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(financiacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FinanciacionExists(financiacion.Id))
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
            ViewData["EjecucionId"] = new SelectList(_context.Ejecuciones, "Id", "Id", financiacion.EjecucionId);
            return View(financiacion);
        }

        // GET: Financiaciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var financiacion = await _context.Financiaciones
                .Include(f => f.Ejecucion)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (financiacion == null)
            {
                return NotFound();
            }

            return View(financiacion);
        }

        // POST: Financiaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var financiacion = await _context.Financiaciones.FindAsync(id);
            _context.Financiaciones.Remove(financiacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FinanciacionExists(int id)
        {
            return _context.Financiaciones.Any(e => e.Id == id);
        }
    }
}
