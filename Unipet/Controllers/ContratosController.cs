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
    public class ContratosController : Controller
    {
        private readonly Context _context;

        public ContratosController(Context context)
        {
            _context = context;
        }

        // GET: Contratos
        public async Task<IActionResult> Index()
        {
            var context = _context.Contratos.Include(c => c.Empresa).Include(c => c.Pet).Include(c => c.Plano).Include(c => c.Tutor);
            return View(await context.ToListAsync());
        }

        // GET: Contratos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contrato = await _context.Contratos
                .Include(c => c.Empresa)
                .Include(c => c.Pet)
                .Include(c => c.Plano)
                .Include(c => c.Tutor)
                .FirstOrDefaultAsync(m => m.IdContrato == id);
            if (contrato == null)
            {
                return NotFound();
            }

            return View(contrato);
        }

        // GET: Contratos/Create
        public IActionResult Create()
        {
            ViewData["IdEmpresa"] = new SelectList(_context.Empresas, "IdEmpresa", "RazaoSocial");
            ViewData["IdPet"] = new SelectList(_context.Pets, "IdPet", "NomePet");
            ViewData["IdPlano"] = new SelectList(_context.Planos, "IdPlano", "NomePlano");
            ViewData["IdTutor"] = new SelectList(_context.Tutores, "IdTutor", "NomeTutor");
            return View();
        }

        // POST: Contratos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdContrato,DataInicio,DataTermino,ValorCombinado,IdPlano,IdTutor,IdPet,IdEmpresa")] Contrato contrato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contrato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEmpresa"] = new SelectList(_context.Empresas, "IdEmpresa", "Email", contrato.IdEmpresa);
            ViewData["IdPet"] = new SelectList(_context.Pets, "IdPet", "NomePet", contrato.IdPet);
            ViewData["IdPlano"] = new SelectList(_context.Planos, "IdPlano", "Descricao", contrato.IdPlano);
            ViewData["IdTutor"] = new SelectList(_context.Tutores, "IdTutor", "Celular", contrato.IdTutor);
            return View(contrato);
        }

        // GET: Contratos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contrato = await _context.Contratos.FindAsync(id);
            if (contrato == null)
            {
                return NotFound();
            }
            ViewData["IdEmpresa"] = new SelectList(_context.Empresas, "IdEmpresa", "Email", contrato.IdEmpresa);
            ViewData["IdPet"] = new SelectList(_context.Pets, "IdPet", "NomePet", contrato.IdPet);
            ViewData["IdPlano"] = new SelectList(_context.Planos, "IdPlano", "Descricao", contrato.IdPlano);
            ViewData["IdTutor"] = new SelectList(_context.Tutores, "IdTutor", "Celular", contrato.IdTutor);
            return View(contrato);
        }

        // POST: Contratos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdContrato,DataInicio,DataTermino,ValorCombinado,IdPlano,IdTutor,IdPet,IdEmpresa")] Contrato contrato)
        {
            if (id != contrato.IdContrato)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contrato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContratoExists(contrato.IdContrato))
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
            ViewData["IdEmpresa"] = new SelectList(_context.Empresas, "IdEmpresa", "Email", contrato.IdEmpresa);
            ViewData["IdPet"] = new SelectList(_context.Pets, "IdPet", "NomePet", contrato.IdPet);
            ViewData["IdPlano"] = new SelectList(_context.Planos, "IdPlano", "Descricao", contrato.IdPlano);
            ViewData["IdTutor"] = new SelectList(_context.Tutores, "IdTutor", "Celular", contrato.IdTutor);
            return View(contrato);
        }

        // GET: Contratos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contrato = await _context.Contratos
                .Include(c => c.Empresa)
                .Include(c => c.Pet)
                .Include(c => c.Plano)
                .Include(c => c.Tutor)
                .FirstOrDefaultAsync(m => m.IdContrato == id);
            if (contrato == null)
            {
                return NotFound();
            }

            return View(contrato);
        }

        // POST: Contratos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contrato = await _context.Contratos.FindAsync(id);
            _context.Contratos.Remove(contrato);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContratoExists(int id)
        {
            return _context.Contratos.Any(e => e.IdContrato == id);
        }
    }
}
