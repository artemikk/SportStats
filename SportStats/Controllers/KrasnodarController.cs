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
    public class KrasnodarController : Controller
    {
        private readonly SportStatsContext _context;

        public KrasnodarController(SportStatsContext context)
        {
            _context = context;
        }

        // GET: Krasnodar
        public async Task<IActionResult> Index()
        {
              return _context.Krasnodar != null ? 
                          View(await _context.Krasnodar.ToListAsync()) :
                          Problem("Entity set 'SportStatsContext.Krasnodar'  is null.");
        }

        // GET: Krasnodar/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Krasnodar == null)
            {
                return NotFound();
            }

            var krasnodar = await _context.Krasnodar
                .FirstOrDefaultAsync(m => m.Title == id);
            if (krasnodar == null)
            {
                return NotFound();
            }

            return View(krasnodar);
        }

        // GET: Krasnodar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Krasnodar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Krasnodar krasnodar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(krasnodar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(krasnodar);
        }

        // GET: Krasnodar/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Krasnodar == null)
            {
                return NotFound();
            }

            var krasnodar = await _context.Krasnodar.FindAsync(id);
            if (krasnodar == null)
            {
                return NotFound();
            }
            return View(krasnodar);
        }

        // POST: Krasnodar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Krasnodar krasnodar)
        {
            if (id != krasnodar.Title)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(krasnodar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KrasnodarExists(krasnodar.Title))
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
            return View(krasnodar);
        }

        // GET: Krasnodar/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Krasnodar == null)
            {
                return NotFound();
            }

            var krasnodar = await _context.Krasnodar
                .FirstOrDefaultAsync(m => m.Title == id);
            if (krasnodar == null)
            {
                return NotFound();
            }

            return View(krasnodar);
        }

        // POST: Krasnodar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Krasnodar == null)
            {
                return Problem("Entity set 'SportStatsContext.Krasnodar'  is null.");
            }
            var krasnodar = await _context.Krasnodar.FindAsync(id);
            if (krasnodar != null)
            {
                _context.Krasnodar.Remove(krasnodar);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KrasnodarExists(string id)
        {
          return (_context.Krasnodar?.Any(e => e.Title == id)).GetValueOrDefault();
        }
    }
}
