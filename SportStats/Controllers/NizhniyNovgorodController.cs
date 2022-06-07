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
    public class NizhniyNovgorodController : Controller
    {
        private readonly SportStatsContext _context;

        public NizhniyNovgorodController(SportStatsContext context)
        {
            _context = context;
        }

        // GET: NizhniyNovgorod
        public async Task<IActionResult> Index()
        {
              return _context.NizhniyNovgorod != null ? 
                          View(await _context.NizhniyNovgorod.ToListAsync()) :
                          Problem("Entity set 'SportStatsContext.NizhniyNovgorod'  is null.");
        }

        // GET: NizhniyNovgorod/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NizhniyNovgorod == null)
            {
                return NotFound();
            }

            var nizhniyNovgorod = await _context.NizhniyNovgorod
                .FirstOrDefaultAsync(m => m.Title == id);
            if (nizhniyNovgorod == null)
            {
                return NotFound();
            }

            return View(nizhniyNovgorod);
        }

        // GET: NizhniyNovgorod/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NizhniyNovgorod/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] NizhniyNovgorod nizhniyNovgorod)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nizhniyNovgorod);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nizhniyNovgorod);
        }

        // GET: NizhniyNovgorod/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NizhniyNovgorod == null)
            {
                return NotFound();
            }

            var nizhniyNovgorod = await _context.NizhniyNovgorod.FindAsync(id);
            if (nizhniyNovgorod == null)
            {
                return NotFound();
            }
            return View(nizhniyNovgorod);
        }

        // POST: NizhniyNovgorod/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Title,Stadium,Head_Coach,Home_Win,Guest_Win,Home_Goals,Guest_Goals,YellowRoughPlay,YellowUnsportsmanlikeBehavior,YellowDisruptionOfTheAttack,Yellow_Other,Yellow_Cards,Red_Cards")] NizhniyNovgorod nizhniyNovgorod)
        {
            if (id != nizhniyNovgorod.Title)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nizhniyNovgorod);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NizhniyNovgorodExists(nizhniyNovgorod.Title))
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
            return View(nizhniyNovgorod);
        }

        // GET: NizhniyNovgorod/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.NizhniyNovgorod == null)
            {
                return NotFound();
            }

            var nizhniyNovgorod = await _context.NizhniyNovgorod
                .FirstOrDefaultAsync(m => m.Title == id);
            if (nizhniyNovgorod == null)
            {
                return NotFound();
            }

            return View(nizhniyNovgorod);
        }

        // POST: NizhniyNovgorod/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.NizhniyNovgorod == null)
            {
                return Problem("Entity set 'SportStatsContext.NizhniyNovgorod'  is null.");
            }
            var nizhniyNovgorod = await _context.NizhniyNovgorod.FindAsync(id);
            if (nizhniyNovgorod != null)
            {
                _context.NizhniyNovgorod.Remove(nizhniyNovgorod);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NizhniyNovgorodExists(string id)
        {
          return (_context.NizhniyNovgorod?.Any(e => e.Title == id)).GetValueOrDefault();
        }
    }
}
