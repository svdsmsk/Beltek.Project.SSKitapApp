using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Beltek.Project.SSKitapApp.Models;

namespace Beltek.Project.SSKitapApp.Controllers
{
    public class StationaryController : Controller
    {
        private readonly SSKitapContext _context;

        public StationaryController(SSKitapContext context)
        {
            _context = context;
        }

        // GET: Stationary
        public async Task<IActionResult> Index()
        {
            return View(await _context.Stationary.ToListAsync());
        }

        // GET: Stationary/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stationary = await _context.Stationary
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stationary == null)
            {
                return NotFound();
            }

            return View(stationary);
        }

        // GET: Stationary/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Stationary/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Product,ProductPrice")] Stationary stationary)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stationary);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stationary);
        }

        // GET: Stationary/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stationary = await _context.Stationary.FindAsync(id);
            if (stationary == null)
            {
                return NotFound();
            }
            return View(stationary);
        }

        // POST: Stationary/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Product,ProductPrice")] Stationary stationary)
        {
            if (id != stationary.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stationary);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StationaryExists(stationary.Id))
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
            return View(stationary);
        }

        // GET: Stationary/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stationary = await _context.Stationary
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stationary == null)
            {
                return NotFound();
            }

            return View(stationary);
        }

        // POST: Stationary/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stationary = await _context.Stationary.FindAsync(id);
            _context.Stationary.Remove(stationary);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StationaryExists(int id)
        {
            return _context.Stationary.Any(e => e.Id == id);
        }
    }
}
