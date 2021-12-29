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
    public class BooktypesController : Controller
    {
        private readonly SSKitapContext _context;

        public BooktypesController(SSKitapContext context)
        {
            _context = context;
        }

        // GET: Booktypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Booktypes.ToListAsync());
        }

        // GET: Booktypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booktypes = await _context.Booktypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booktypes == null)
            {
                return NotFound();
            }

            return View(booktypes);
        }

        // GET: Booktypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Booktypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BookType")] Booktypes booktypes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booktypes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(booktypes);
        }

        // GET: Booktypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booktypes = await _context.Booktypes.FindAsync(id);
            if (booktypes == null)
            {
                return NotFound();
            }
            return View(booktypes);
        }

        // POST: Booktypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BookType")] Booktypes booktypes)
        {
            if (id != booktypes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booktypes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BooktypesExists(booktypes.Id))
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
            return View(booktypes);
        }

        // GET: Booktypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booktypes = await _context.Booktypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booktypes == null)
            {
                return NotFound();
            }

            return View(booktypes);
        }

        // POST: Booktypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booktypes = await _context.Booktypes.FindAsync(id);
            _context.Booktypes.Remove(booktypes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BooktypesExists(int id)
        {
            return _context.Booktypes.Any(e => e.Id == id);
        }
    }
}
