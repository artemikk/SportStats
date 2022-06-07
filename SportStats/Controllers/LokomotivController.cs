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
    public class LokomotivController : Controller
    {
        private readonly SportStatsContext _context;

        public LokomotivController(SportStatsContext context)
        {
            _context = context;
        }

        // GET: Lokomotiv
        public async Task<IActionResult> Index()
        {
              return _context.Lokomotiv != null ? 
                          View(await _context.Lokomotiv.ToListAsync()) :
                          Problem("Entity set 'SportStatsContext.Lokomotiv'  is null.");
        }

        // GET: Lokomotiv/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Lokomotiv == null)
            {
                return NotFound();
            }

            var lokomotiv = await _context.Lokomotiv
                .FirstOrDefaultAsync(m => m.Title == id);
            if (lokomotiv == null)
            {
                return NotFound();
            }

            return View(lokomotiv);
        }

        // GET: Lokomotiv/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lokomotiv/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Lokomotiv lokomotiv)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lokomotiv);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lokomotiv);
        }

        // GET: Lokomotiv/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Lokomotiv == null)
            {
                return NotFound();
            }

            var lokomotiv = await _context.Lokomotiv.FindAsync(id);
            if (lokomotiv == null)
            {
                return NotFound();
            }
            return View(lokomotiv);
        }

        // POST: Lokomotiv/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Lokomotiv lokomotiv)
        {
            if (id != lokomotiv.Title)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lokomotiv);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LokomotivExists(lokomotiv.Title))
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
            return View(lokomotiv);
        }

        // GET: Lokomotiv/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Lokomotiv == null)
            {
                return NotFound();
            }

            var lokomotiv = await _context.Lokomotiv
                .FirstOrDefaultAsync(m => m.Title == id);
            if (lokomotiv == null)
            {
                return NotFound();
            }

            return View(lokomotiv);
        }

        // POST: Lokomotiv/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Lokomotiv == null)
            {
                return Problem("Entity set 'SportStatsContext.Lokomotiv'  is null.");
            }
            var lokomotiv = await _context.Lokomotiv.FindAsync(id);
            if (lokomotiv != null)
            {
                _context.Lokomotiv.Remove(lokomotiv);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LokomotivExists(string id)
        {
          return (_context.Lokomotiv?.Any(e => e.Title == id)).GetValueOrDefault();
        }
    }
}
