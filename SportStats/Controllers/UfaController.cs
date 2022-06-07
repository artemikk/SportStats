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
    public class UfaController : Controller
    {
        private readonly SportStatsContext _context;

        public UfaController(SportStatsContext context)
        {
            _context = context;
        }

        // GET: Ufa
        public async Task<IActionResult> Index()
        {
              return _context.Ufa != null ? 
                          View(await _context.Ufa.ToListAsync()) :
                          Problem("Entity set 'SportStatsContext.Ufa'  is null.");
        }

        // GET: Ufa/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Ufa == null)
            {
                return NotFound();
            }

            var ufa = await _context.Ufa
                .FirstOrDefaultAsync(m => m.Title == id);
            if (ufa == null)
            {
                return NotFound();
            }

            return View(ufa);
        }

        // GET: Ufa/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ufa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Ufa ufa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ufa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ufa);
        }

        // GET: Ufa/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Ufa == null)
            {
                return NotFound();
            }

            var ufa = await _context.Ufa.FindAsync(id);
            if (ufa == null)
            {
                return NotFound();
            }
            return View(ufa);
        }

        // POST: Ufa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Ufa ufa)
        {
            if (id != ufa.Title)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ufa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UfaExists(ufa.Title))
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
            return View(ufa);
        }

        // GET: Ufa/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Ufa == null)
            {
                return NotFound();
            }

            var ufa = await _context.Ufa
                .FirstOrDefaultAsync(m => m.Title == id);
            if (ufa == null)
            {
                return NotFound();
            }

            return View(ufa);
        }

        // POST: Ufa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Ufa == null)
            {
                return Problem("Entity set 'SportStatsContext.Ufa'  is null.");
            }
            var ufa = await _context.Ufa.FindAsync(id);
            if (ufa != null)
            {
                _context.Ufa.Remove(ufa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UfaExists(string id)
        {
          return (_context.Ufa?.Any(e => e.Title == id)).GetValueOrDefault();
        }
    }
}
