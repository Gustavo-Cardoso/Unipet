using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Unipet.Data;
using Unipet.Models;

namespace Unipet.Controllers
{
    public class RelatosController : Controller
    {
        private readonly Context _context;

        public RelatosController(Context context)
        {
            _context = context;
        }

        // GET: Relatos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Relatos.ToListAsync());
        }

        // GET: Relatos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var relato = await _context.Relatos
                .FirstOrDefaultAsync(m => m.IdRelato == id);
            if (relato == null)
            {
                return NotFound();
            }

            return View(relato);
        }

        // GET: Relatos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Relatos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdRelato,Nome,Texto,Foto,ExibirHome")] Relato relato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(relato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(relato);
        }

        // GET: Relatos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var relato = await _context.Relatos.FindAsync(id);
            if (relato == null)
            {
                return NotFound();
            }
            return View(relato);
        }

        // POST: Relatos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdRelato,Nome,Texto,Foto,ExibirHome")] Relato relato)
        {
            if (id != relato.IdRelato)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(relato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RelatoExists(relato.IdRelato))
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
            return View(relato);
        }

        // GET: Relatos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var relato = await _context.Relatos
                .FirstOrDefaultAsync(m => m.IdRelato == id);
            if (relato == null)
            {
                return NotFound();
            }

            return View(relato);
        }

        // POST: Relatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var relato = await _context.Relatos.FindAsync(id);
            _context.Relatos.Remove(relato);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RelatoExists(int id)
        {
            return _context.Relatos.Any(e => e.IdRelato == id);
        }
    }
}
