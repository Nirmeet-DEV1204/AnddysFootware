using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AnddysFootware.Data;
using AnddysFootware.Models;

namespace AnddysFootware.Controllers
{
    public class AndysFootwaresController : Controller
    {
        private readonly AnddysFootwareContext _context;

        public AndysFootwaresController(AnddysFootwareContext context)
        {
            _context = context;
        }

        // GET: AndysFootwares
        public async Task<IActionResult> Index()
        {
            return View(await _context.AndysFootware.ToListAsync());
        }

        // GET: AndysFootwares/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var andysFootware = await _context.AndysFootware
                .FirstOrDefaultAsync(m => m.id == id);
            if (andysFootware == null)
            {
                return NotFound();
            }

            return View(andysFootware);
        }

        // GET: AndysFootwares/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AndysFootwares/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,companyName,category,modelName,color,size,rating")] AndysFootware andysFootware)
        {
            if (ModelState.IsValid)
            {
                _context.Add(andysFootware);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(andysFootware);
        }

        // GET: AndysFootwares/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var andysFootware = await _context.AndysFootware.FindAsync(id);
            if (andysFootware == null)
            {
                return NotFound();
            }
            return View(andysFootware);
        }

        // POST: AndysFootwares/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,companyName,category,modelName,color,size,rating")] AndysFootware andysFootware)
        {
            if (id != andysFootware.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(andysFootware);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AndysFootwareExists(andysFootware.id))
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
            return View(andysFootware);
        }

        // GET: AndysFootwares/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var andysFootware = await _context.AndysFootware
                .FirstOrDefaultAsync(m => m.id == id);
            if (andysFootware == null)
            {
                return NotFound();
            }

            return View(andysFootware);
        }

        // POST: AndysFootwares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var andysFootware = await _context.AndysFootware.FindAsync(id);
            _context.AndysFootware.Remove(andysFootware);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AndysFootwareExists(int id)
        {
            return _context.AndysFootware.Any(e => e.id == id);
        }
    }
}
