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
    public class TugsController : Controller
    {
        private readonly StarMatrixContext _context;

        public TugsController(StarMatrixContext context)
        {
            _context = context;
        }

        // GET: Tugs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tug.ToListAsync());
        }

        // GET: Tugs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tug = await _context.Tug
                .FirstOrDefaultAsync(m => m.TugId == id);
            if (tug == null)
            {
                return NotFound();
            }

            return View(tug);
        }

        // GET: Tugs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tugs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Tug tug)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tug);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tug);
        }

        // GET: Tugs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tug = await _context.Tug.FindAsync(id);
            if (tug == null)
            {
                return NotFound();
            }
            return View(tug);
        }

        // POST: Tugs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Tug tug)
        {
            if (id != tug.TugId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tug);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TugExists(tug.TugId))
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
            return View(tug);
        }

        // GET: Tugs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tug = await _context.Tug
                .FirstOrDefaultAsync(m => m.TugId == id);
            if (tug == null)
            {
                return NotFound();
            }

            return View(tug);
        }

        // POST: Tugs/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tug = await _context.Tug.FindAsync(id);
            _context.Tug.Remove(tug);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TugExists(int id)
        {
            return _context.Tug.Any(e => e.TugId == id);
        }
    }
}
