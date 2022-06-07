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
    public class RubinController : Controller
    {
        private readonly SportStatsContext _context;

        public RubinController(SportStatsContext context)
        {
            _context = context;
        }

        // GET: Rubin
        public async Task<IActionResult> Index()
        {
              return _context.Rubin != null ? 
                          View(await _context.Rubin.ToListAsync()) :
                          Problem("Entity set 'SportStatsContext.Rubin'  is null.");
        }

        // GET: Rubin/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Rubin == null)
            {
                return NotFound();
            }

            var rubin = await _context.Rubin
                .FirstOrDefaultAsync(m => m.Title == id);
            if (rubin == null)
            {
                return NotFound();
            }

            return View(rubin);
        }

        // GET: Rubin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rubin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Rubin rubin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rubin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rubin);
        }

        // GET: Rubin/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Rubin == null)
            {
                return NotFound();
            }

            var rubin = await _context.Rubin.FindAsync(id);
            if (rubin == null)
            {
                return NotFound();
            }
            return View(rubin);
        }

        // POST: Rubin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Rubin rubin)
        {
            if (id != rubin.Title)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rubin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RubinExists(rubin.Title))
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
            return View(rubin);
        }

        // GET: Rubin/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Rubin == null)
            {
                return NotFound();
            }

            var rubin = await _context.Rubin
                .FirstOrDefaultAsync(m => m.Title == id);
            if (rubin == null)
            {
                return NotFound();
            }

            return View(rubin);
        }

        // POST: Rubin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Rubin == null)
            {
                return Problem("Entity set 'SportStatsContext.Rubin'  is null.");
            }
            var rubin = await _context.Rubin.FindAsync(id);
            if (rubin != null)
            {
                _context.Rubin.Remove(rubin);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RubinExists(string id)
        {
          return (_context.Rubin?.Any(e => e.Title == id)).GetValueOrDefault();
        }
    }
}
