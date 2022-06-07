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
    public class DynamoController : Controller
    {
        private readonly SportStatsContext _context;

        public DynamoController(SportStatsContext context)
        {
            _context = context;
        }

        // GET: Dynamo
        public async Task<IActionResult> Index()
        {
              return _context.Dynamo != null ? 
                          View(await _context.Dynamo.ToListAsync()) :
                          Problem("Entity set 'SportStatsContext.Dynamo'  is null.");
        }

        // GET: Dynamo/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Dynamo == null)
            {
                return NotFound();
            }

            var dynamo = await _context.Dynamo
                .FirstOrDefaultAsync(m => m.Title == id);
            if (dynamo == null)
            {
                return NotFound();
            }

            return View(dynamo);
        }

        // GET: Dynamo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dynamo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Dynamo dynamo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dynamo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dynamo);
        }

        // GET: Dynamo/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Dynamo == null)
            {
                return NotFound();
            }

            var dynamo = await _context.Dynamo.FindAsync(id);
            if (dynamo == null)
            {
                return NotFound();
            }
            return View(dynamo);
        }

        // POST: Dynamo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] Dynamo dynamo)
        {
            if (id != dynamo.Title)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dynamo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DynamoExists(dynamo.Title))
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
            return View(dynamo);
        }

        // GET: Dynamo/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Dynamo == null)
            {
                return NotFound();
            }

            var dynamo = await _context.Dynamo
                .FirstOrDefaultAsync(m => m.Title == id);
            if (dynamo == null)
            {
                return NotFound();
            }

            return View(dynamo);
        }

        // POST: Dynamo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Dynamo == null)
            {
                return Problem("Entity set 'SportStatsContext.Dynamo'  is null.");
            }
            var dynamo = await _context.Dynamo.FindAsync(id);
            if (dynamo != null)
            {
                _context.Dynamo.Remove(dynamo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DynamoExists(string id)
        {
          return (_context.Dynamo?.Any(e => e.Title == id)).GetValueOrDefault();
        }
    }
}
