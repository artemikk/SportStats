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
    public class KhimkiController : Controller
    {
        private readonly SportStatsContext _context;

        public KhimkiController(SportStatsContext context)
        {
            _context = context;
        }

        // GET: Khimki
        public async Task<IActionResult> Index()
        {
              return _context.Khimki != null ? 
                          View(await _context.Khimki.ToListAsync()) :
                          Problem("Entity set 'SportStatsContext.Khimki'  is null.");
        }

        // GET: Khimki/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Khimki == null)
            {
                return NotFound();
            }

            var khimki = await _context.Khimki
                .FirstOrDefaultAsync(m => m.Title == id);
            if (khimki == null)
            {
                return NotFound();
            }

            return View(khimki);
        }

        // GET: Khimki/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Khimki/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Khimki khimki)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khimki);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(khimki);
        }

        // GET: Khimki/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Khimki == null)
            {
                return NotFound();
            }

            var khimki = await _context.Khimki.FindAsync(id);
            if (khimki == null)
            {
                return NotFound();
            }
            return View(khimki);
        }

        // POST: Khimki/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Khimki khimki)
        {
            if (id != khimki.Title)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khimki);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhimkiExists(khimki.Title))
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
            return View(khimki);
        }

        // GET: Khimki/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Khimki == null)
            {
                return NotFound();
            }

            var khimki = await _context.Khimki
                .FirstOrDefaultAsync(m => m.Title == id);
            if (khimki == null)
            {
                return NotFound();
            }

            return View(khimki);
        }

        // POST: Khimki/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Khimki == null)
            {
                return Problem("Entity set 'SportStatsContext.Khimki'  is null.");
            }
            var khimki = await _context.Khimki.FindAsync(id);
            if (khimki != null)
            {
                _context.Khimki.Remove(khimki);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhimkiExists(string id)
        {
          return (_context.Khimki?.Any(e => e.Title == id)).GetValueOrDefault();
        }
    }
}
