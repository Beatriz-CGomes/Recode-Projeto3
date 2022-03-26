#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Modulo.Models;

namespace Modulo.Controllers
{
    public class FalasController : Controller
    {
        private readonly Context _context;

        public FalasController(Context context)
        {
            _context = context;
        }

        // GET: Falas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Falas.ToListAsync());
        }

        // GET: Falas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fala = await _context.Falas
                .FirstOrDefaultAsync(m => m.Id_fala == id);
            if (fala == null)
            {
                return NotFound();
            }

            return View(fala);
        }

        // GET: Falas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Falas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_fala,Nome,Email,Mensagem")] Fala fala)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fala);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fala);
        }

        // GET: Falas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fala = await _context.Falas.FindAsync(id);
            if (fala == null)
            {
                return NotFound();
            }
            return View(fala);
        }

        // POST: Falas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_fala,Nome,Email,Mensagem")] Fala fala)
        {
            if (id != fala.Id_fala)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fala);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FalaExists(fala.Id_fala))
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
            return View(fala);
        }

        // GET: Falas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fala = await _context.Falas
                .FirstOrDefaultAsync(m => m.Id_fala == id);
            if (fala == null)
            {
                return NotFound();
            }

            return View(fala);
        }

        // POST: Falas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fala = await _context.Falas.FindAsync(id);
            _context.Falas.Remove(fala);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FalaExists(int id)
        {
            return _context.Falas.Any(e => e.Id_fala == id);
        }
    }
}
