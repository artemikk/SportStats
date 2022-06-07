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
    public class SpartakController : Controller
    {
        private readonly SportStatsContext _context;

        public SpartakController(SportStatsContext context)
        {
            _context = context;
        }

        // GET: Spartak
        public async Task<IActionResult> Index()
        {
              return _context.Spartak != null ? 
                          View(await _context.Spartak.ToListAsync()) :
                          Problem("Entity set 'SportStatsContext.Spartak'  is null.");
        }

        // GET: Spartak/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Spartak == null)
            {
                return NotFound();
            }

            var spartak = await _context.Spartak
                .FirstOrDefaultAsync(m => m.Title == id);
            if (spartak == null)
            {
                return NotFound();
            }

            return View(spartak);
        }

        // GET: Spartak/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Spartak/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Spartak spartak)
        {
            if (ModelState.IsValid)
            {
                _context.Add(spartak);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(spartak);
        }

        // GET: Spartak/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Spartak == null)
            {
                return NotFound();
            }

            var spartak = await _context.Spartak.FindAsync(id);
            if (spartak == null)
            {
                return NotFound();
            }
            return View(spartak);
        }

        // POST: Spartak/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Spartak spartak)
        {
            if (id != spartak.Title)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(spartak);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpartakExists(spartak.Title))
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
            return View(spartak);
        }

        // GET: Spartak/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Spartak == null)
            {
                return NotFound();
            }

            var spartak = await _context.Spartak
                .FirstOrDefaultAsync(m => m.Title == id);
            if (spartak == null)
            {
                return NotFound();
            }

            return View(spartak);
        }

        // POST: Spartak/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Spartak == null)
            {
                return Problem("Entity set 'SportStatsContext.Spartak'  is null.");
            }
            var spartak = await _context.Spartak.FindAsync(id);
            if (spartak != null)
            {
                _context.Spartak.Remove(spartak);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpartakExists(string id)
        {
          return (_context.Spartak?.Any(e => e.Title == id)).GetValueOrDefault();
        }
    }
}
