using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZooAndAnimalFun.Data;
using ZooAndAnimalFun.Models;

namespace ZooAndAnimalFun.Controllers
{
    public class SpeciesController : Controller
    {
        private readonly ZooAndAnimalFunContext _context;

        public SpeciesController(ZooAndAnimalFunContext context)
        {
            _context = context;
        }

        // GET: Species
        public async Task<IActionResult> Index()
        {
            var animals = _context.Species
                .Include(a => a.EventCategory);

            return View(await _context.Species.ToListAsync());
        }

        // GET: Species/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var species = await _context.Species
                .FirstOrDefaultAsync(m => m.SpeciesID == id);
            if (species == null)
            {
                return NotFound();
            }

            return View(species);
        }

        // GET: Species/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Species/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SpeciesID,SpeciesName,CategoryID")] Species species)
        {
            if (ModelState.IsValid)
            {
                _context.Add(species);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(species);
        }

        // GET: Species/Edit/5
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var species = await _context.Species.FindAsync(id);
            if (species == null)
            {
                return NotFound();
            }
            return View(species);
        }

        // POST: Species/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("SpeciesID,SpeciesName,CategoryID")] Species species)
        {
            if (id != species.SpeciesID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(species);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpeciesExists(species.SpeciesID))
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
            return View(species);
        }

        // GET: Species/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var species = await _context.Species
                .FirstOrDefaultAsync(m => m.SpeciesID == id);
            if (species == null)
            {
                return NotFound();
            }

            return View(species);
        }

        // POST: Species/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var species = await _context.Species.FindAsync(id);
            if (species != null)
            {
                _context.Species.Remove(species);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpeciesExists(string id)
        {
            return _context.Species.Any(e => e.SpeciesID == id);
        }
    }
}
