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
    public class CSKAController : Controller
    {
        private readonly SportStatsContext _context;

        public CSKAController(SportStatsContext context)
        {
            _context = context;
        }

        // GET: CSKA
        public async Task<IActionResult> Index()
        {
              return _context.CSKA != null ? 
                          View(await _context.CSKA.ToListAsync()) :
                          Problem("Entity set 'SportStatsContext.CSKA'  is null.");
        }

        // GET: CSKA/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.CSKA == null)
            {
                return NotFound();
            }

            var cSKA = await _context.CSKA
                .FirstOrDefaultAsync(m => m.Title == id);
            if (cSKA == null)
            {
                return NotFound();
            }

            return View(cSKA);
        }

        // GET: CSKA/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CSKA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] CSKA cSKA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cSKA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cSKA);
        }

        // GET: CSKA/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.CSKA == null)
            {
                return NotFound();
            }

            var cSKA = await _context.CSKA.FindAsync(id);
            if (cSKA == null)
            {
                return NotFound();
            }
            return View(cSKA);
        }

        // POST: CSKA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] CSKA cSKA)
        {
            if (id != cSKA.Title)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cSKA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CSKAExists(cSKA.Title))
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
            return View(cSKA);
        }

        // GET: CSKA/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.CSKA == null)
            {
                return NotFound();
            }

            var cSKA = await _context.CSKA
                .FirstOrDefaultAsync(m => m.Title == id);
            if (cSKA == null)
            {
                return NotFound();
            }

            return View(cSKA);
        }

        // POST: CSKA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.CSKA == null)
            {
                return Problem("Entity set 'SportStatsContext.CSKA'  is null.");
            }
            var cSKA = await _context.CSKA.FindAsync(id);
            if (cSKA != null)
            {
                _context.CSKA.Remove(cSKA);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CSKAExists(string id)
        {
          return (_context.CSKA?.Any(e => e.Title == id)).GetValueOrDefault();
        }
    }
}
