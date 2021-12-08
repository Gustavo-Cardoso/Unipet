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
    public class PlanosController : Controller
    {
        private readonly Context _context;

        public PlanosController(Context context)
        {
            _context = context;
        }

        // GET: Planos
        public async Task<IActionResult> Index()
        {
            var context = _context.Planos.Include(p => p.AreaCobertura).Include(p => p.Empresa);
            return View(await context.ToListAsync());
        }

        // GET: Planos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plano = await _context.Planos
                .Include(p => p.AreaCobertura)
                .Include(p => p.Empresa)
                .FirstOrDefaultAsync(m => m.IdPlano == id);
            if (plano == null)
            {
                return NotFound();
            }

            return View(plano);
        }

        // GET: Planos/Create
        public IActionResult Create()
        {
            ViewData["IdArea"] = new SelectList(_context.Set<AreaCobertura>(), "IdArea", "NomeArea");
            ViewData["IdEmpresa"] = new SelectList(_context.Empresas, "IdEmpresa", "RazaoSocial");
            return View();
        }

        // POST: Planos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPlano,NomePlano,Descricao,Valor,IdArea,IdEmpresa,ExibirHome")] Plano plano)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plano);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdArea"] = new SelectList(_context.Set<AreaCobertura>(), "IdArea", "NomeArea", plano.IdArea);
            ViewData["IdEmpresa"] = new SelectList(_context.Empresas, "IdEmpresa", "RazaoSocial", plano.IdEmpresa);
            return View(plano);
        }

        // GET: Planos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plano = await _context.Planos.FindAsync(id);
            if (plano == null)
            {
                return NotFound();
            }
            ViewData["IdArea"] = new SelectList(_context.Set<AreaCobertura>(), "IdArea", "NomeArea", plano.IdArea);
            ViewData["IdEmpresa"] = new SelectList(_context.Empresas, "IdEmpresa", "RazaoSocial", plano.IdEmpresa);
            return View(plano);
        }

        // POST: Planos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPlano,NomePlano,Descricao,Valor,IdArea,IdEmpresa,ExibirHome")] Plano plano)
        {
            if (id != plano.IdPlano)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plano);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanoExists(plano.IdPlano))
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
            ViewData["IdArea"] = new SelectList(_context.Set<AreaCobertura>(), "IdArea", "NomeArea", plano.IdArea);
            ViewData["IdEmpresa"] = new SelectList(_context.Empresas, "IdEmpresa", "RazaoSocial", plano.IdEmpresa);
            return View(plano);
        }

        // GET: Planos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plano = await _context.Planos
                .Include(p => p.AreaCobertura)
                .Include(p => p.Empresa)
                .FirstOrDefaultAsync(m => m.IdPlano == id);
            if (plano == null)
            {
                return NotFound();
            }

            return View(plano);
        }

        // POST: Planos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plano = await _context.Planos.FindAsync(id);
            _context.Planos.Remove(plano);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanoExists(int id)
        {
            return _context.Planos.Any(e => e.IdPlano == id);
        }
    }
}
