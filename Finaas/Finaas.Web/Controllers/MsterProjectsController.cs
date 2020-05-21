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
    public class MsterProjectsController : Controller
    {
        private readonly InvestigacionContext _context;

        public MsterProjectsController(InvestigacionContext context)
        {
            _context = context;
        }

        // GET: MsterProjects
        public async Task<IActionResult> Index()
        {
            var investigacionContext = _context.Ejecuciones.Include(m => m.Grupo);
            return View(await investigacionContext.ToListAsync());
        }

        // GET: MsterProjects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var msterProject = await _context.Ejecuciones
                .Include(m => m.Grupo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (msterProject == null)
            {
                return NotFound();
            }

            return View(msterProject);
        }

        // GET: MsterProjects/Create
        public IActionResult Create()
        {
            ViewData["GrupoId"] = new SelectList(_context.Grupos, "Id", "Id");
            return View();
        }

        // POST: MsterProjects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,GrupoId,FechaAprobacion,FechaIniciacion,Presupuesto,DisponibilidadPresupuestal,UnidadApoyo,Regulacion,Categoria")] MasterProject msterProject)
        {
            if (ModelState.IsValid)
            {
                _context.Add(msterProject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GrupoId"] = new SelectList(_context.Grupos, "Id", "Id", msterProject.GrupoId);
            return View(msterProject);
        }

        // GET: MsterProjects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var msterProject = await _context.Ejecuciones.FindAsync(id);
            if (msterProject == null)
            {
                return NotFound();
            }
            ViewData["GrupoId"] = new SelectList(_context.Grupos, "Id", "Id", msterProject.GrupoId);
            return View(msterProject);
        }

        // POST: MsterProjects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,GrupoId,FechaAprobacion,FechaIniciacion,Presupuesto,DisponibilidadPresupuestal,UnidadApoyo,Regulacion,Categoria")] MasterProject msterProject)
        {
            if (id != msterProject.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(msterProject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MsterProjectExists(msterProject.Id))
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
            ViewData["GrupoId"] = new SelectList(_context.Grupos, "Id", "Id", msterProject.GrupoId);
            return View(msterProject);
        }

        // GET: MsterProjects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var msterProject = await _context.Ejecuciones
                .Include(m => m.Grupo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (msterProject == null)
            {
                return NotFound();
            }

            return View(msterProject);
        }

        // POST: MsterProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var msterProject = await _context.Ejecuciones.FindAsync(id);
            _context.Ejecuciones.Remove(msterProject);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MsterProjectExists(int id)
        {
            return _context.Ejecuciones.Any(e => e.Id == id);
        }
    }
}
