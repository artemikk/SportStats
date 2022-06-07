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
    public class AkhmatController : Controller
    {
        private readonly SportStatsContext _context;

        public AkhmatController(SportStatsContext context)
        {
            _context = context;
        }

        // GET: Akhmat
        public async Task<IActionResult> Index()
        {
              return _context.Akhmat != null ? 
                          View(await _context.Akhmat.ToListAsync()) :
                          Problem("Entity set 'SportStatsContext.Akhmat'  is null.");
        }

        // GET: Akhmat/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Akhmat == null)
            {
                return NotFound();
            }

            var akhmat = await _context.Akhmat
                .FirstOrDefaultAsync(m => m.Title == id);
            if (akhmat == null)
            {
                return NotFound();
            }

            return View(akhmat);
        }

        // GET: Akhmat/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Akhmat/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Akhmat akhmat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(akhmat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(akhmat);
        }

        // GET: Akhmat/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Akhmat == null)
            {
                return NotFound();
            }

            var akhmat = await _context.Akhmat.FindAsync(id);
            if (akhmat == null)
            {
                return NotFound();
            }
            return View(akhmat);
        }

        // POST: Akhmat/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Akhmat akhmat)
        {
            if (id != akhmat.Title)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(akhmat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AkhmatExists(akhmat.Title))
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
            return View(akhmat);
        }

        // GET: Akhmat/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Akhmat == null)
            {
                return NotFound();
            }

            var akhmat = await _context.Akhmat
                .FirstOrDefaultAsync(m => m.Title == id);
            if (akhmat == null)
            {
                return NotFound();
            }

            return View(akhmat);
        }

        // POST: Akhmat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Akhmat == null)
            {
                return Problem("Entity set 'SportStatsContext.Akhmat'  is null.");
            }
            var akhmat = await _context.Akhmat.FindAsync(id);
            if (akhmat != null)
            {
                _context.Akhmat.Remove(akhmat);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AkhmatExists(string id)
        {
          return (_context.Akhmat?.Any(e => e.Title == id)).GetValueOrDefault();
        }
    }
}
