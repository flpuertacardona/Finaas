﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Finaas.Web.Data.Investigacion;

namespace Finaas.Web.Controllers
{
    public class ActividadesController : Controller
    {
        private readonly InvestigacionContext _context;

        public ActividadesController(InvestigacionContext context)
        {
            _context = context;
        }

        // GET: Actividades
        public async Task<IActionResult> Index()
        {
            var investigacionContext = _context.Actividades.Include(a => a.Agenda).Include(a => a.Publicacion);
            return View(await investigacionContext.ToListAsync());
        }

        // GET: Actividades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actividad = await _context.Actividades
                .Include(a => a.Agenda)
                .Include(a => a.Publicacion)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (actividad == null)
            {
                return NotFound();
            }

            return View(actividad);
        }

        // GET: Actividades/Create
        public IActionResult Create()
        {
            ViewData["AgendaId"] = new SelectList(_context.Agendas, "Id", "Id");
            ViewData["PublicacionId"] = new SelectList(_context.Publicaciones, "Id", "Id");
            return View();
        }

        // POST: Actividades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,AgendaId,FechaActividad,CategoriaAprociacion,ProgrmaId,Categoria,Regulacion,UnidadApoyo,ImageUrl,Lugar,PublicacionId,CategoriaProyecto")] Actividad actividad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(actividad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AgendaId"] = new SelectList(_context.Agendas, "Id", "Id", actividad.AgendaId);
            ViewData["PublicacionId"] = new SelectList(_context.Publicaciones, "Id", "Id", actividad.PublicacionId);
            return View(actividad);
        }

        // GET: Actividades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actividad = await _context.Actividades.FindAsync(id);
            if (actividad == null)
            {
                return NotFound();
            }
            ViewData["AgendaId"] = new SelectList(_context.Agendas, "Id", "Id", actividad.AgendaId);
            ViewData["PublicacionId"] = new SelectList(_context.Publicaciones, "Id", "Id", actividad.PublicacionId);
            return View(actividad);
        }

        // POST: Actividades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,AgendaId,FechaActividad,CategoriaAprociacion,ProgrmaId,Categoria,Regulacion,UnidadApoyo,ImageUrl,Lugar,PublicacionId,CategoriaProyecto")] Actividad actividad)
        {
            if (id != actividad.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(actividad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActividadExists(actividad.Id))
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
            ViewData["AgendaId"] = new SelectList(_context.Agendas, "Id", "Id", actividad.AgendaId);
            ViewData["PublicacionId"] = new SelectList(_context.Publicaciones, "Id", "Id", actividad.PublicacionId);
            return View(actividad);
        }

        // GET: Actividades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actividad = await _context.Actividades
                .Include(a => a.Agenda)
                .Include(a => a.Publicacion)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (actividad == null)
            {
                return NotFound();
            }

            return View(actividad);
        }

        // POST: Actividades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actividad = await _context.Actividades.FindAsync(id);
            _context.Actividades.Remove(actividad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActividadExists(int id)
        {
            return _context.Actividades.Any(e => e.Id == id);
        }
    }
}
