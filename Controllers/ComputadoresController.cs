using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoDeLaboratorios.DAL;
using GestaoDeLaboratorios.Models;

namespace GestaoDeLaboratorios.Controllers
{
    public class ComputadoresController : Controller
    {
        private readonly InfnetDbContext _context;

        public ComputadoresController(InfnetDbContext context)
        {
            _context = context;
        }

        // GET: Computadores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Computadores.ToListAsync());
        }

        // GET: Computadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computador = await _context.Computadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (computador == null)
            {
                return NotFound();
            }

            return View(computador);
        }

        // GET: Computadores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Computadores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Marca,Processador,PlacaMae,Memoria,Hd,NumeroPratrimonio,DataDeEntrega")] Computador computador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(computador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(computador);
        }

        // GET: Computadores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computador = await _context.Computadores.FindAsync(id);
            if (computador == null)
            {
                return NotFound();
            }
            return View(computador);
        }

        // POST: Computadores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Marca,Processador,PlacaMae,Memoria,Hd,NumeroPratrimonio,DataDeEntrega")] Computador computador)
        {
            if (id != computador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(computador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComputadorExists(computador.Id))
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
            return View(computador);
        }

        // GET: Computadores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computador = await _context.Computadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (computador == null)
            {
                return NotFound();
            }

            return View(computador);
        }

        // POST: Computadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var computador = await _context.Computadores.FindAsync(id);
            if (computador != null)
            {
                _context.Computadores.Remove(computador);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComputadorExists(int id)
        {
            return _context.Computadores.Any(e => e.Id == id);
        }
    }
}
