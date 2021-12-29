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
    public class BookWritersController : Controller
    {
        private readonly SSKitapContext _context;

        public BookWritersController(SSKitapContext context)
        {
            _context = context;
        }

        // GET: BookWriters
        public async Task<IActionResult> Index()
        {
            return View(await _context.BookWriters.ToListAsync());
        }

        // GET: BookWriters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookWriters = await _context.BookWriters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookWriters == null)
            {
                return NotFound();
            }

            return View(bookWriters);
        }

        // GET: BookWriters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BookWriters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,WriterName,WriterSurname,DateTime")] BookWriters bookWriters)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookWriters);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookWriters);
        }

        // GET: BookWriters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookWriters = await _context.BookWriters.FindAsync(id);
            if (bookWriters == null)
            {
                return NotFound();
            }
            return View(bookWriters);
        }

        // POST: BookWriters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,WriterName,WriterSurname,DateTime")] BookWriters bookWriters)
        {
            if (id != bookWriters.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookWriters);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookWritersExists(bookWriters.Id))
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
            return View(bookWriters);
        }

        // GET: BookWriters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookWriters = await _context.BookWriters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookWriters == null)
            {
                return NotFound();
            }

            return View(bookWriters);
        }

        // POST: BookWriters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookWriters = await _context.BookWriters.FindAsync(id);
            _context.BookWriters.Remove(bookWriters);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookWritersExists(int id)
        {
            return _context.BookWriters.Any(e => e.Id == id);
        }
    }
}
