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
    public class SochiController : Controller
    {
        private readonly SportStatsContext _context;

        public SochiController(SportStatsContext context)
        {
            _context = context;
        }

        // GET: Sochi
        public async Task<IActionResult> Index()
        {
              return _context.Sochi != null ? 
                          View(await _context.Sochi.ToListAsync()) :
                          Problem("Entity set 'SportStatsContext.Sochi'  is null.");
        }

        // GET: Sochi/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Sochi == null)
            {
                return NotFound();
            }

            var sochi = await _context.Sochi
                .FirstOrDefaultAsync(m => m.Title == id);
            if (sochi == null)
            {
                return NotFound();
            }

            return View(sochi);
        }

        // GET: Sochi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sochi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Sochi sochi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sochi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sochi);
        }

        // GET: Sochi/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Sochi == null)
            {
                return NotFound();
            }

            var sochi = await _context.Sochi.FindAsync(id);
            if (sochi == null)
            {
                return NotFound();
            }
            return View(sochi);
        }

        // POST: Sochi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Sochi sochi)
        {
            if (id != sochi.Title)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sochi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SochiExists(sochi.Title))
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
            return View(sochi);
        }

        // GET: Sochi/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Sochi == null)
            {
                return NotFound();
            }

            var sochi = await _context.Sochi
                .FirstOrDefaultAsync(m => m.Title == id);
            if (sochi == null)
            {
                return NotFound();
            }

            return View(sochi);
        }

        // POST: Sochi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Sochi == null)
            {
                return Problem("Entity set 'SportStatsContext.Sochi'  is null.");
            }
            var sochi = await _context.Sochi.FindAsync(id);
            if (sochi != null)
            {
                _context.Sochi.Remove(sochi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SochiExists(string id)
        {
          return (_context.Sochi?.Any(e => e.Title == id)).GetValueOrDefault();
        }
    }
}
