using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportStats.Data;
using SportStats.Models;

namespace SportStats.Controllers
{
    public class KrylyaSovetovController : Controller
    {
        private readonly SportStatsContext _context;

        public KrylyaSovetovController(SportStatsContext context)
        {
            _context = context;
        }

        // GET: KrylyaSovetov
        public async Task<IActionResult> Index()
        {
              return _context.KrylyaSovetov != null ? 
                          View(await _context.KrylyaSovetov.ToListAsync()) :
                          Problem("Entity set 'SportStatsContext.KrylyaSovetov'  is null.");
        }

        // GET: KrylyaSovetov/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.KrylyaSovetov == null)
            {
                return NotFound();
            }

            var krylyaSovetov = await _context.KrylyaSovetov
                .FirstOrDefaultAsync(m => m.Title == id);
            if (krylyaSovetov == null)
            {
                return NotFound();
            }

            return View(krylyaSovetov);
        }

        // GET: KrylyaSovetov/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KrylyaSovetov/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] KrylyaSovetov krylyaSovetov)
        {
            if (ModelState.IsValid)
            {
                _context.Add(krylyaSovetov);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(krylyaSovetov);
        }

        // GET: KrylyaSovetov/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.KrylyaSovetov == null)
            {
                return NotFound();
            }

            var krylyaSovetov = await _context.KrylyaSovetov.FindAsync(id);
            if (krylyaSovetov == null)
            {
                return NotFound();
            }
            return View(krylyaSovetov);
        }

        // POST: KrylyaSovetov/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] KrylyaSovetov krylyaSovetov)
        {
            if (id != krylyaSovetov.Title)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(krylyaSovetov);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KrylyaSovetovExists(krylyaSovetov.Title))
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
            return View(krylyaSovetov);
        }

        // GET: KrylyaSovetov/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.KrylyaSovetov == null)
            {
                return NotFound();
            }

            var krylyaSovetov = await _context.KrylyaSovetov
                .FirstOrDefaultAsync(m => m.Title == id);
            if (krylyaSovetov == null)
            {
                return NotFound();
            }

            return View(krylyaSovetov);
        }

        // POST: KrylyaSovetov/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.KrylyaSovetov == null)
            {
                return Problem("Entity set 'SportStatsContext.KrylyaSovetov'  is null.");
            }
            var krylyaSovetov = await _context.KrylyaSovetov.FindAsync(id);
            if (krylyaSovetov != null)
            {
                _context.KrylyaSovetov.Remove(krylyaSovetov);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KrylyaSovetovExists(string id)
        {
          return (_context.KrylyaSovetov?.Any(e => e.Title == id)).GetValueOrDefault();
        }
    }
}
