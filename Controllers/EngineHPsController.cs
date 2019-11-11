using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StarMatrix.Models;

namespace StarMatrix.Controllers
{
    public class EngineHPsController : Controller
    {
        private readonly StarMatrixContext _context;

        public EngineHPsController(StarMatrixContext context)
        {
            _context = context;
        }

        // GET: EngineHPs
        public async Task<IActionResult> Index()
        {
            return View(await _context.EngineHP.ToListAsync());
        }

        // GET: EngineHPs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var engineHP = await _context.EngineHP
                .FirstOrDefaultAsync(m => m.EngineHPId == id);
            if (engineHP == null)
            {
                return NotFound();
            }

            return View(engineHP);
        }

        // GET: EngineHPs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EngineHPs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EngineHPId,EngineHPName")] EngineHP engineHP)
        {
            if (ModelState.IsValid)
            {
                _context.Add(engineHP);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(engineHP);
        }

        // GET: EngineHPs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var engineHP = await _context.EngineHP.FindAsync(id);
            if (engineHP == null)
            {
                return NotFound();
            }
            return View(engineHP);
        }

        // POST: EngineHPs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EngineHPId,EngineHPName")] EngineHP engineHP)
        {
            if (id != engineHP.EngineHPId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(engineHP);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EngineHPExists(engineHP.EngineHPId))
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
            return View(engineHP);
        }

        // GET: EngineHPs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var engineHP = await _context.EngineHP
                .FirstOrDefaultAsync(m => m.EngineHPId == id);
            if (engineHP == null)
            {
                return NotFound();
            }

            return View(engineHP);
        }

        // POST: EngineHPs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var engineHP = await _context.EngineHP.FindAsync(id);
            _context.EngineHP.Remove(engineHP);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EngineHPExists(int id)
        {
            return _context.EngineHP.Any(e => e.EngineHPId == id);
        }
    }
}
