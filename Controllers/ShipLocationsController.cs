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
    public class ShipLocationsController : Controller
    {
        private readonly StarMatrixContext _context;

        public ShipLocationsController(StarMatrixContext context)
        {
            _context = context;
        }

        // GET: ShipLocations
        public async Task<IActionResult> Index()
        {
            var starMatrixContext = _context.ShipLocation.Include(s => s.Tugs);
            return View(await starMatrixContext.ToListAsync());
        }

        // GET: ShipLocations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shipLocation = await _context.ShipLocation                
                .Include(s => s.Tugs)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shipLocation == null)
            {
                return NotFound();
            }

            return View(shipLocation);
        }

        // GET: ShipLocations/Create
        public IActionResult Create()
        {          
            ViewData["TugId"] = new SelectList(_context.Tug, "TugId", "TugName");
            return View();
        }

        // POST: ShipLocations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TugId,PresentLocation,Availability,AvailableLocation,Ipaddress,DateAdded")] ShipLocation shipLocation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shipLocation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }         
            ViewData["TugId"] = new SelectList(_context.Tug, "TugId", "TugName", shipLocation.TugId);
            return View(shipLocation);
        }

        // GET: ShipLocations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shipLocation = await _context.ShipLocation.FindAsync(id);
            if (shipLocation == null)
            {
                return NotFound();
            }
          
            ViewData["TugId"] = new SelectList(_context.Tug, "TugId", "TugName", shipLocation.TugId);
            return View(shipLocation);
        }

        // POST: ShipLocations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TugId,PresentLocation,Availability,AvailableLocation,Ipaddress,DateAdded")] ShipLocation shipLocation)
        {
            if (id != shipLocation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shipLocation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShipLocationExists(shipLocation.Id))
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
            ViewData["TugId"] = new SelectList(_context.Tug, "TugId", "TugName", shipLocation.TugId);
            return View(shipLocation);
        }

        // GET: ShipLocations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shipLocation = await _context.ShipLocation
               
                .Include(s => s.Tugs)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shipLocation == null)
            {
                return NotFound();
            }

            return View(shipLocation);
        }

        // POST: ShipLocations/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shipLocation = await _context.ShipLocation.FindAsync(id);
            _context.ShipLocation.Remove(shipLocation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShipLocationExists(int id)
        {
            return _context.ShipLocation.Any(e => e.Id == id);
        }
    }
}
