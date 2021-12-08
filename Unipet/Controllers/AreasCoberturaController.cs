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
    public class AreasCoberturaController : Controller
    {
        private readonly Context _context;

        public AreasCoberturaController(Context context)
        {
            _context = context;
        }

        // GET: AreasCobertura
        public async Task<IActionResult> Index()
        {
            var context = _context.AreaCobertura.Include(a => a.Empresa).Include(a => a.Municipio);
            return View(await context.ToListAsync());
        }

        // GET: AreasCobertura/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var areaCobertura = await _context.AreaCobertura
                .Include(a => a.Empresa)
                .Include(a => a.Municipio)
                .FirstOrDefaultAsync(m => m.IdArea == id);
            if (areaCobertura == null)
            {
                return NotFound();
            }

            return View(areaCobertura);
        }

        // GET: AreasCobertura/Create
        public IActionResult Create()
        {
            ViewData["IdEmpresa"] = new SelectList(_context.Empresas, "IdEmpresa", "RazaoSocial", "Email", "Fone");
            ViewData["IdMunicipio"] = new SelectList(_context.Municipios, "IdMunicipio", "NomeMunicipio");
            return View();
        }

        // POST: AreasCobertura/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdArea,NomeArea,IdMunicipio,IdEmpresa")] AreaCobertura areaCobertura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(areaCobertura);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEmpresa"] = new SelectList(_context.Empresas, "IdEmpresa", "RazaoSocial", areaCobertura.IdEmpresa);
            ViewData["IdMunicipio"] = new SelectList(_context.Municipios, "IdMunicipio", "NomeMunicipio", areaCobertura.IdMunicipio);
            return View(areaCobertura);
        }

        // GET: AreasCobertura/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var areaCobertura = await _context.AreaCobertura.FindAsync(id);
            if (areaCobertura == null)
            {
                return NotFound();
            }
            ViewData["IdEmpresa"] = new SelectList(_context.Empresas, "IdEmpresa", "RazaoSocial", areaCobertura.IdEmpresa);
            ViewData["IdMunicipio"] = new SelectList(_context.Municipios, "IdMunicipio", "NomeMunicipio", areaCobertura.IdMunicipio);
            return View(areaCobertura);
        }

        // POST: AreasCobertura/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdArea,NomeArea,IdMunicipio,IdEmpresa")] AreaCobertura areaCobertura)
        {
            if (id != areaCobertura.IdArea)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(areaCobertura);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AreaCoberturaExists(areaCobertura.IdArea))
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
            ViewData["IdEmpresa"] = new SelectList(_context.Empresas, "IdEmpresa", "Email", areaCobertura.IdEmpresa);
            ViewData["IdMunicipio"] = new SelectList(_context.Municipios, "IdMunicipio", "NomeMunicipio", areaCobertura.IdMunicipio);
            return View(areaCobertura);
        }

        // GET: AreasCobertura/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var areaCobertura = await _context.AreaCobertura
                .Include(a => a.Empresa)
                .Include(a => a.Municipio)
                .FirstOrDefaultAsync(m => m.IdArea == id);
            if (areaCobertura == null)
            {
                return NotFound();
            }

            return View(areaCobertura);
        }

        // POST: AreasCobertura/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var areaCobertura = await _context.AreaCobertura.FindAsync(id);
            _context.AreaCobertura.Remove(areaCobertura);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AreaCoberturaExists(int id)
        {
            return _context.AreaCobertura.Any(e => e.IdArea == id);
        }
    }
}
