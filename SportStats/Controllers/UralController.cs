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
    public class UralController : Controller
    {
        private readonly SportStatsContext _context;

        public UralController(SportStatsContext context)
        {
            _context = context;
        }

        // GET: Ural
        public async Task<IActionResult> Index()
        {
              return _context.Ural != null ? 
                          View(await _context.Ural.ToListAsync()) :
                          Problem("Entity set 'SportStatsContext.Ural'  is null.");
        }

        // GET: Ural/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Ural == null)
            {
                return NotFound();
            }

            var ural = await _context.Ural
                .FirstOrDefaultAsync(m => m.Title == id);
            if (ural == null)
            {
                return NotFound();
            }

            return View(ural);
        }

        // GET: Ural/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ural/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Ural ural)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ural);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ural);
        }

        // GET: Ural/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Ural == null)
            {
                return NotFound();
            }

            var ural = await _context.Ural.FindAsync(id);
            if (ural == null)
            {
                return NotFound();
            }
            return View(ural);
        }

        // POST: Ural/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Ural ural)
        {
            if (id != ural.Title)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ural);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UralExists(ural.Title))
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
            return View(ural);
        }

        // GET: Ural/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Ural == null)
            {
                return NotFound();
            }

            var ural = await _context.Ural
                .FirstOrDefaultAsync(m => m.Title == id);
            if (ural == null)
            {
                return NotFound();
            }

            return View(ural);
        }

        // POST: Ural/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Ural == null)
            {
                return Problem("Entity set 'SportStatsContext.Ural'  is null.");
            }
            var ural = await _context.Ural.FindAsync(id);
            if (ural != null)
            {
                _context.Ural.Remove(ural);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UralExists(string id)
        {
          return (_context.Ural?.Any(e => e.Title == id)).GetValueOrDefault();
        }
    }
}
