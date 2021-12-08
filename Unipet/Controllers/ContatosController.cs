using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Unipet.Data;
using Unipet.Models;
using Unipet.Services;

namespace Unipet.Controllers
{
    public class ContatosController : Controller
    {
        private readonly Context _context;
        private readonly int pageSize = 10;

        public ContatosController(Context context)
        {
            _context = context;
        }

        // GET: Contatos
        public ActionResult Index()
        {
            var contatos = PaginatedList<Contato>.Create(_context.Contatos.AsQueryable(), 1, pageSize);
            return View(contatos);
        }

        [HttpGet]
        public PartialViewResult GetGrid(string sortOrder, string searchString, int? pageNumber)
        {
            ViewData["NameSortParm"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            //ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["CurrentFilter"] = searchString;

            var contatos = _context.Contatos.AsQueryable();

            if (!String.IsNullOrEmpty(searchString))
            {
                contatos = contatos.Where(s => s.Nome.Contains(searchString)
                                          || s.Assunto.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    contatos = contatos.OrderByDescending(s => s.Nome);
                    break;
                //case "Date":
                //    contatos = contatos.OrderBy(s => s.DataCadastro);
                //    break;
                //case "date_desc":
                //    contatos = contatos.OrderByDescending(s => s.Data);
                //    break;
                default:
                    contatos = contatos.OrderBy(s => s.Nome);
                    break;
            }

            var retorno = PaginatedList<Contato>.Create(contatos, pageNumber ?? 1, pageSize);
            return PartialView("_Grid", retorno);
        }

        // GET: Contatos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contato = await _context.Contatos
                .FirstOrDefaultAsync(m => m.IdContato == id);
            if (contato == null)
            {
                return NotFound();
            }

            return View(contato);
        }

        // GET: Contatos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contatos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdContato,Nome,Assunto,Email,Telefone,Celular,Mensagem")] Contato contato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contato);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest("Preencha o formulario para enviar o seu contato!");
        }

        // GET: Contatos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contato = await _context.Contatos.FindAsync(id);
            if (contato == null)
            {
                return NotFound();
            }
            return View(contato);
        }

        // POST: Contatos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdContato,Nome,Assunto,Email,Telefone,Celular,Mensagem")] Contato contato)
        {
            if (id != contato.IdContato)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContatoExists(contato.IdContato))
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
            return View(contato);
        }

        // GET: Contatos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contato = await _context.Contatos
                .FirstOrDefaultAsync(m => m.IdContato == id);
            if (contato == null)
            {
                return NotFound();
            }

            return View(contato);
        }

        // POST: Contatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contato = await _context.Contatos.FindAsync(id);
            _context.Contatos.Remove(contato);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContatoExists(int id)
        {
            return _context.Contatos.Any(e => e.IdContato == id);
        }
    }
}
