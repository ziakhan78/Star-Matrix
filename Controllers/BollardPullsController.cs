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
    public class BollardPullsController : Controller
    {
        private readonly StarMatrixContext _context;

        public BollardPullsController(StarMatrixContext context)
        {
            _context = context;
        }

        // GET: BollardPulls
        public async Task<IActionResult> Index()
        {
            return View(await _context.BollardPull.ToListAsync());
        }

        // GET: BollardPulls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bollardPull = await _context.BollardPull
                .FirstOrDefaultAsync(m => m.BollardPullId == id);
            if (bollardPull == null)
            {
                return NotFound();
            }

            return View(bollardPull);
        }

        // GET: BollardPulls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BollardPulls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BollardPullId,BollardPullName")] BollardPull bollardPull)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bollardPull);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bollardPull);
        }

        // GET: BollardPulls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bollardPull = await _context.BollardPull.FindAsync(id);
            if (bollardPull == null)
            {
                return NotFound();
            }
            return View(bollardPull);
        }

        // POST: BollardPulls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BollardPullId,BollardPullName")] BollardPull bollardPull)
        {
            if (id != bollardPull.BollardPullId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bollardPull);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BollardPullExists(bollardPull.BollardPullId))
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
            return View(bollardPull);
        }

        // GET: BollardPulls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bollardPull = await _context.BollardPull
                .FirstOrDefaultAsync(m => m.BollardPullId == id);
            if (bollardPull == null)
            {
                return NotFound();
            }

            return View(bollardPull);
        }

        // POST: BollardPulls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bollardPull = await _context.BollardPull.FindAsync(id);
            _context.BollardPull.Remove(bollardPull);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BollardPullExists(int id)
        {
            return _context.BollardPull.Any(e => e.BollardPullId == id);
        }
    }
}
