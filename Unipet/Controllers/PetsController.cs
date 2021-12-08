﻿using System;
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
    public class PetsController : Controller
    {
        private readonly Context _context;

        public PetsController(Context context)
        {
            _context = context;
        }

        // GET: Pets
        public async Task<IActionResult> Index()
        {
            var context = _context.Pets.Include(p => p.Especie).Include(p => p.Porte).Include(p => p.Raca).Include(p => p.Tutor);
            return View(await context.ToListAsync());
        }

        // GET: Pets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _context.Pets
                .Include(p => p.Especie)
                .Include(p => p.Porte)
                .Include(p => p.Raca)
                .Include(p => p.Tutor)
                .FirstOrDefaultAsync(m => m.IdPet == id);
            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }

        // GET: Pets/Create
        public IActionResult Create()
        {
            ViewData["IdEspecie"] = new SelectList(_context.Especies, "IdEspecie", "NomeEspecie");
            ViewData["IdPorte"] = new SelectList(_context.Portes, "IdPorte", "NomePorte");
            ViewData["IdRaca"] = new SelectList(_context.Racas, "IdRaca", "NomeRaca");
            ViewData["IdTutor"] = new SelectList(_context.Tutores, "IdTutor", "CPF");
            return View();
        }

        // POST: Pets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPet,NomePet,DataNascimento,Sexo,IdTutor,IdEspecie,IdRaca,IdPorte,ExibirHome")] Pet pet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEspecie"] = new SelectList(_context.Especies, "IdEspecie", "NomeEspecie", pet.IdEspecie);
            ViewData["IdPorte"] = new SelectList(_context.Portes, "IdPorte", "NomePorte", pet.IdPorte);
            ViewData["IdRaca"] = new SelectList(_context.Racas, "IdRaca", "NomeRaca", pet.IdRaca);
            ViewData["IdTutor"] = new SelectList(_context.Tutores, "IdTutor", "CPF", pet.IdTutor);
            return View(pet);
        }

        // GET: Pets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _context.Pets.FindAsync(id);
            if (pet == null)
            {
                return NotFound();
            }
            ViewData["IdEspecie"] = new SelectList(_context.Especies, "IdEspecie", "NomeEspecie", pet.IdEspecie);
            ViewData["IdPorte"] = new SelectList(_context.Portes, "IdPorte", "NomePorte", pet.IdPorte);
            ViewData["IdRaca"] = new SelectList(_context.Racas, "IdRaca", "NomeRaca", pet.IdRaca);
            ViewData["IdTutor"] = new SelectList(_context.Tutores, "IdTutor", "CPF", pet.IdTutor);
            return View(pet);
        }

        // POST: Pets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPet,NomePet,DataNascimento,Sexo,IdTutor,IdEspecie,IdRaca,IdPorte,ExibirHome")] Pet pet)
        {
            if (id != pet.IdPet)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PetExists(pet.IdPet))
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
            ViewData["IdEspecie"] = new SelectList(_context.Especies, "IdEspecie", "NomeEspecie", pet.IdEspecie);
            ViewData["IdPorte"] = new SelectList(_context.Portes, "IdPorte", "NomePorte", pet.IdPorte);
            ViewData["IdRaca"] = new SelectList(_context.Racas, "IdRaca", "NomeRaca", pet.IdRaca);
            ViewData["IdTutor"] = new SelectList(_context.Tutores, "IdTutor", "CPF", pet.IdTutor);
            return View(pet);
        }

        // GET: Pets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _context.Pets
                .Include(p => p.Especie)
                .Include(p => p.Porte)
                .Include(p => p.Raca)
                .Include(p => p.Tutor)
                .FirstOrDefaultAsync(m => m.IdPet == id);
            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }

        // POST: Pets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pet = await _context.Pets.FindAsync(id);
            _context.Pets.Remove(pet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PetExists(int id)
        {
            return _context.Pets.Any(e => e.IdPet == id);
        }
    }
}
