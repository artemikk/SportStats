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
    public class ZenitController : Controller
    {
        private readonly SportStatsContext _context;

        public ZenitController(SportStatsContext context)
        {
            _context = context;
        }

        // GET: Zenit
        public async Task<IActionResult> Index()
        {
              return _context.Zenit != null ? 
                          View(await _context.Zenit.ToListAsync()) :
                          Problem("Entity set 'SportStatsContext.Zenit'  is null.");
        }

        // GET: Zenit/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Zenit == null)
            {
                return NotFound();
            }

            var zenit = await _context.Zenit
                .FirstOrDefaultAsync(m => m.Title == id);
            if (zenit == null)
            {
                return NotFound();
            }

            return View(zenit);
        }

        // GET: Zenit/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Zenit/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Zenit zenit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zenit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zenit);
        }

        // GET: Zenit/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Zenit == null)
            {
                return NotFound();
            }

            var zenit = await _context.Zenit.FindAsync(id);
            if (zenit == null)
            {
                return NotFound();
            }
            return View(zenit);
        }

        // POST: Zenit/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Zenit zenit)
        {
            if (id != zenit.Title)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zenit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZenitExists(zenit.Title))
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
            return View(zenit);
        }

        // GET: Zenit/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Zenit == null)
            {
                return NotFound();
            }

            var zenit = await _context.Zenit
                .FirstOrDefaultAsync(m => m.Title == id);
            if (zenit == null)
            {
                return NotFound();
            }

            return View(zenit);
        }

        // POST: Zenit/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Zenit == null)
            {
                return Problem("Entity set 'SportStatsContext.Zenit'  is null.");
            }
            var zenit = await _context.Zenit.FindAsync(id);
            if (zenit != null)
            {
                _context.Zenit.Remove(zenit);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZenitExists(string id)
        {
          return (_context.Zenit?.Any(e => e.Title == id)).GetValueOrDefault();
        }
    }
}
