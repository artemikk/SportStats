using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportStats.Data;

namespace SportStats.Controllers
{
    public class TeamsController : Controller
    {
        private readonly SportStatsContext _context;

        public TeamsController(SportStatsContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Akhmat()
        {
            return _context.Akhmat != null ?
                        View(await _context.Akhmat.ToListAsync()) :
                        Problem("Entity set 'WebApplication5Context.Zenit_Class'  is null.");
        }
        public async Task<IActionResult> Arsenal()
        {
            return _context.Arsenal != null ?
                        View(await _context.Arsenal.ToListAsync()) :
                        Problem("Entity set 'WebApplication5Context.Zenit_Class'  is null.");
        }
        public async Task<IActionResult> CSKA()
        {
            return _context.CSKA != null ?
                        View(await _context.CSKA.ToListAsync()) :
                        Problem("Entity set 'WebApplication5Context.Zenit_Class'  is null.");
        }
        public async Task<IActionResult> Dynamo()
        {
            return _context.Dynamo != null ?
                        View(await _context.Dynamo.ToListAsync()) :
                        Problem("Entity set 'WebApplication5Context.Zenit_Class'  is null.");
        }
        public async Task<IActionResult> Khimki()
        {
            return _context.Khimki != null ?
                        View(await _context.Khimki.ToListAsync()) :
                        Problem("Entity set 'WebApplication5Context.Zenit_Class'  is null.");
        }
        public async Task<IActionResult> Krasnodar()
        {
            return _context.Krasnodar != null ?
                        View(await _context.Krasnodar.ToListAsync()) :
                        Problem("Entity set 'WebApplication5Context.Zenit_Class'  is null.");
        }
        public async Task<IActionResult> KrylyaSovetov()
        {
            return _context.KrylyaSovetov != null ?
                        View(await _context.KrylyaSovetov.ToListAsync()) :
                        Problem("Entity set 'WebApplication5Context.Zenit_Class'  is null.");
        }
        public async Task<IActionResult> Lokomotiv()
        {
            return _context.Lokomotiv != null ?
                        View(await _context.Lokomotiv.ToListAsync()) :
                        Problem("Entity set 'WebApplication5Context.Zenit_Class'  is null.");
        }
        public async Task<IActionResult> NizhniyNovgorod()
        {
            return _context.NizhniyNovgorod != null ?
                        View(await _context.NizhniyNovgorod.ToListAsync()) :
                        Problem("Entity set 'WebApplication5Context.Zenit_Class'  is null.");
        }
        public async Task<IActionResult> Rostov()
        {
            return _context.Rostov != null ?
                        View(await _context.Rostov.ToListAsync()) :
                        Problem("Entity set 'WebApplication5Context.Zenit_Class'  is null.");
        }
        public async Task<IActionResult> Rubin()
        {
            return _context.Rubin != null ?
                        View(await _context.Rubin.ToListAsync()) :
                        Problem("Entity set 'WebApplication5Context.Zenit_Class'  is null.");
        }
        public async Task<IActionResult> Sochi()
        {
            return _context.Sochi != null ?
                        View(await _context.Sochi.ToListAsync()) :
                        Problem("Entity set 'WebApplication5Context.Zenit_Class'  is null.");
        }
        public async Task<IActionResult> Spartak()
        {
            return _context.Spartak != null ?
                        View(await _context.Spartak.ToListAsync()) :
                        Problem("Entity set 'WebApplication5Context.Zenit_Class'  is null.");
        }
        public async Task<IActionResult> Ufa()
        {
            return _context.Ufa != null ?
                        View(await _context.Ufa.ToListAsync()) :
                        Problem("Entity set 'WebApplication5Context.Zenit_Class'  is null.");
        }
        public async Task<IActionResult> Ural()
        {
            return _context.Ural != null ?
                        View(await _context.Ural.ToListAsync()) :
                        Problem("Entity set 'WebApplication5Context.Zenit_Class'  is null.");
        }
        public async Task<IActionResult> Zenit()
        {
            return _context.Zenit != null ?
                        View(await _context.Zenit.ToListAsync()) :
                        Problem("Entity set 'WebApplication5Context.Zenit_Class'  is null.");
        }

    }
}
