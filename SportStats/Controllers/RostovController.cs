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
    public class RostovController : Controller
    {
        private readonly SportStatsContext _context;

        public RostovController(SportStatsContext context)
        {
            _context = context;
        }

        // GET: Rostov
        public async Task<IActionResult> Index()
        {
              return _context.Rostov != null ? 
                          View(await _context.Rostov.ToListAsync()) :
                          Problem("Entity set 'SportStatsContext.Rostov'  is null.");
        }

        // GET: Rostov/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Rostov == null)
            {
                return NotFound();
            }

            var rostov = await _context.Rostov
                .FirstOrDefaultAsync(m => m.Title == id);
            if (rostov == null)
            {
                return NotFound();
            }

            return View(rostov);
        }

        // GET: Rostov/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rostov/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Rostov rostov)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rostov);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rostov);
        }

        // GET: Rostov/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Rostov == null)
            {
                return NotFound();
            }

            var rostov = await _context.Rostov.FindAsync(id);
            if (rostov == null)
            {
                return NotFound();
            }
            return View(rostov);
        }

        // POST: Rostov/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Rostov rostov)
        {
            if (id != rostov.Title)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rostov);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RostovExists(rostov.Title))
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
            return View(rostov);
        }

        // GET: Rostov/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Rostov == null)
            {
                return NotFound();
            }

            var rostov = await _context.Rostov
                .FirstOrDefaultAsync(m => m.Title == id);
            if (rostov == null)
            {
                return NotFound();
            }

            return View(rostov);
        }

        // POST: Rostov/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Rostov == null)
            {
                return Problem("Entity set 'SportStatsContext.Rostov'  is null.");
            }
            var rostov = await _context.Rostov.FindAsync(id);
            if (rostov != null)
            {
                _context.Rostov.Remove(rostov);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RostovExists(string id)
        {
          return (_context.Rostov?.Any(e => e.Title == id)).GetValueOrDefault();
        }
    }
}
