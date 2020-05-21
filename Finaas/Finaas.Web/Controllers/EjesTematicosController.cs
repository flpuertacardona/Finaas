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
    public class EjesTematicosController : Controller
    {
        private readonly InvestigacionContext _context;

        public EjesTematicosController(InvestigacionContext context)
        {
            _context = context;
        }

        // GET: EjesTematicos
        public async Task<IActionResult> Index()
        {
            return View(await _context.EjeTematico.ToListAsync());
        }

        // GET: EjesTematicos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ejeTematico = await _context.EjeTematico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ejeTematico == null)
            {
                return NotFound();
            }

            return View(ejeTematico);
        }

        // GET: EjesTematicos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EjesTematicos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] EjeTematico ejeTematico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ejeTematico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ejeTematico);
        }

        // GET: EjesTematicos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ejeTematico = await _context.EjeTematico.FindAsync(id);
            if (ejeTematico == null)
            {
                return NotFound();
            }
            return View(ejeTematico);
        }

        // POST: EjesTematicos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] EjeTematico ejeTematico)
        {
            if (id != ejeTematico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ejeTematico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EjeTematicoExists(ejeTematico.Id))
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
            return View(ejeTematico);
        }

        // GET: EjesTematicos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ejeTematico = await _context.EjeTematico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ejeTematico == null)
            {
                return NotFound();
            }

            return View(ejeTematico);
        }

        // POST: EjesTematicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ejeTematico = await _context.EjeTematico.FindAsync(id);
            _context.EjeTematico.Remove(ejeTematico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EjeTematicoExists(int id)
        {
            return _context.EjeTematico.Any(e => e.Id == id);
        }
    }
}
