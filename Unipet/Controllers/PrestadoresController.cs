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
    public class PrestadoresController : Controller
    {
        private readonly Context _context;

        public PrestadoresController(Context context)
        {
            _context = context;
        }

        // GET: Prestadores
        public async Task<IActionResult> Index()
        {
            var context = _context.Prestador.Include(p => p.Endereco).Include(p => p.Usuario);
            return View(await context.ToListAsync());
        }

        // GET: Prestadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestador = await _context.Prestador
                .Include(p => p.Endereco)
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.IdPrestador == id);
            if (prestador == null)
            {
                return NotFound();
            }

            return View(prestador);
        }

        // GET: Prestadores/Create
        public IActionResult Create()
        {
            ViewData["IdEndereco"] = new SelectList(_context.Enderecos, "IdEndereco", "Logradouro", "NumeroCasa", "CEP");
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Nome");
            return View();
        }

        // POST: Prestadores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPrestador,RazaoSocial,CNPJ,Email,Fone,Logotipo,IdEndereco,IdUsuario,ExibirHome")] Prestador prestador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prestador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEndereco"] = new SelectList(_context.Enderecos, "IdEndereco", "Logradouro", prestador.IdEndereco);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Nome", prestador.IdUsuario);
            return View(prestador);
        }

        // GET: Prestadores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestador = await _context.Prestador.FindAsync(id);
            if (prestador == null)
            {
                return NotFound();
            }
            ViewData["IdEndereco"] = new SelectList(_context.Enderecos, "IdEndereco", "Logradouro", prestador.IdEndereco);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Nome", prestador.IdUsuario);
            return View(prestador);
        }

        // POST: Prestadores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPrestador,RazaoSocial,CNPJ,Email,Fone,Logotipo,IdEndereco,IdUsuario,ExibirHome")] Prestador prestador)
        {
            if (id != prestador.IdPrestador)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prestador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrestadorExists(prestador.IdPrestador))
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
            ViewData["IdEndereco"] = new SelectList(_context.Enderecos, "IdEndereco", "Logradouro", prestador.IdEndereco);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Nome", prestador.IdUsuario);
            return View(prestador);
        }

        // GET: Prestadores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestador = await _context.Prestador
                .Include(p => p.Endereco)
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.IdPrestador == id);
            if (prestador == null)
            {
                return NotFound();
            }

            return View(prestador);
        }

        // POST: Prestadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prestador = await _context.Prestador.FindAsync(id);
            _context.Prestador.Remove(prestador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrestadorExists(int id)
        {
            return _context.Prestador.Any(e => e.IdPrestador == id);
        }
    }
}
