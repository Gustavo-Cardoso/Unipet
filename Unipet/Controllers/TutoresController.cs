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
    public class TutoresController : Controller
    {
        private readonly Context _context;

        public TutoresController(Context context)
        {
            _context = context;
        }

        // GET: Tutores
        public async Task<IActionResult> Index()
        {
            var context = _context.Tutores.Include(t => t.Endereco).Include(t => t.Usuario);
            return View(await context.ToListAsync());
        }

        // GET: Tutores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutor = await _context.Tutores
                .Include(t => t.Endereco)
                .Include(t => t.Usuario)
                .FirstOrDefaultAsync(m => m.IdTutor == id);
            if (tutor == null)
            {
                return NotFound();
            }

            return View(tutor);
        }

        // GET: Tutores/Create
        public IActionResult Create()
        {
            ViewData["IdEndereco"] = new SelectList(_context.Enderecos, "IdEndereco", "Logradouro", "NumeroCasa", "");
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Nome");
            return View();
        }

        // POST: Tutores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTutor,NomeTutor,Email,CPF,RG,Sexo,Foto,Fone,Celular,IdEndereco,IdUsuario,ExibirHome")] Tutor tutor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tutor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEndereco"] = new SelectList(_context.Enderecos, "IdEndereco", "Logradouro", tutor.IdEndereco);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Nome", tutor.IdUsuario);
            return View(tutor);
        }

        // GET: Tutores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutor = await _context.Tutores.FindAsync(id);
            if (tutor == null)
            {
                return NotFound();
            }
            ViewData["IdEndereco"] = new SelectList(_context.Enderecos, "IdEndereco", "Logradouro", tutor.IdEndereco);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Nome", tutor.IdUsuario);
            return View(tutor);
        }

        // POST: Tutores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTutor,NomeTutor,Email,CPF,RG,Sexo,Foto,Fone,Celular,IdEndereco,IdUsuario,ExibirHome")] Tutor tutor)
        {
            if (id != tutor.IdTutor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tutor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TutorExists(tutor.IdTutor))
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
            ViewData["IdEndereco"] = new SelectList(_context.Enderecos, "IdEndereco", "Logradouro", tutor.IdEndereco);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Nome", tutor.IdUsuario);
            return View(tutor);
        }

        // GET: Tutores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutor = await _context.Tutores
                .Include(t => t.Endereco)
                .Include(t => t.Usuario)
                .FirstOrDefaultAsync(m => m.IdTutor == id);
            if (tutor == null)
            {
                return NotFound();
            }

            return View(tutor);
        }

        // POST: Tutores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tutor = await _context.Tutores.FindAsync(id);
            _context.Tutores.Remove(tutor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TutorExists(int id)
        {
            return _context.Tutores.Any(e => e.IdTutor == id);
        }
    }
}