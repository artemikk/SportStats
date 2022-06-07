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
    public class ArsenalController : Controller
    {
        private readonly SportStatsContext _context;

        public ArsenalController(SportStatsContext context)
        {
            _context = context;
        }

        // GET: Arsenal
        public async Task<IActionResult> Index()
        {
              return _context.Arsenal != null ? 
                          View(await _context.Arsenal.ToListAsync()) :
                          Problem("Entity set 'SportStatsContext.Arsenal'  is null.");
        }

        // GET: Arsenal/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Arsenal == null)
            {
                return NotFound();
            }

            var arsenal = await _context.Arsenal
                .FirstOrDefaultAsync(m => m.Title == id);
            if (arsenal == null)
            {
                return NotFound();
            }

            return View(arsenal);
        }

        // GET: Arsenal/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Arsenal/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Arsenal arsenal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(arsenal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(arsenal);
        }

        // GET: Arsenal/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Arsenal == null)
            {
                return NotFound();
            }

            var arsenal = await _context.Arsenal.FindAsync(id);
            if (arsenal == null)
            {
                return NotFound();
            }
            return View(arsenal);
        }

        // POST: Arsenal/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Arsenal arsenal)
        {
            if (id != arsenal.Title)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(arsenal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArsenalExists(arsenal.Title))
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
            return View(arsenal);
        }

        // GET: Arsenal/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Arsenal == null)
            {
                return NotFound();
            }

            var arsenal = await _context.Arsenal
                .FirstOrDefaultAsync(m => m.Title == id);
            if (arsenal == null)
            {
                return NotFound();
            }

            return View(arsenal);
        }

        // POST: Arsenal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Arsenal == null)
            {
                return Problem("Entity set 'SportStatsContext.Arsenal'  is null.");
            }
            var arsenal = await _context.Arsenal.FindAsync(id);
            if (arsenal != null)
            {
                _context.Arsenal.Remove(arsenal);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArsenalExists(string id)
        {
          return (_context.Arsenal?.Any(e => e.Title == id)).GetValueOrDefault();
        }
    }
}
