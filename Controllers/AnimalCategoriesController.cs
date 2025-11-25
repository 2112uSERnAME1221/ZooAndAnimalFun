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
    public class AnimalCategoriesController : Controller
    {
        private readonly ZooAndAnimalFunContext _context;

        public AnimalCategoriesController(ZooAndAnimalFunContext context)
        {
            _context = context;
        }

        // GET: AnimalCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.AnimalCategories.ToListAsync());
        }

        // GET: AnimalCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animalCategories = await _context.AnimalCategories
                .FirstOrDefaultAsync(m => m.CategoryID == id);
            if (animalCategories == null)
            {
                return NotFound();
            }

            return View(animalCategories);
        }

        // GET: AnimalCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AnimalCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryID,CategoryName")] AnimalCategories animalCategories)
        {
            if (ModelState.IsValid)
            {
                _context.Add(animalCategories);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(animalCategories);
        }

        // GET: AnimalCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animalCategories = await _context.AnimalCategories.FindAsync(id);
            if (animalCategories == null)
            {
                return NotFound();
            }
            return View(animalCategories);
        }

        // POST: AnimalCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryID,CategoryName")] AnimalCategories animalCategories)
        {
            if (id != animalCategories.CategoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(animalCategories);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnimalCategoriesExists(animalCategories.CategoryID))
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
            return View(animalCategories);
        }

        // GET: AnimalCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animalCategories = await _context.AnimalCategories
                .FirstOrDefaultAsync(m => m.CategoryID == id);
            if (animalCategories == null)
            {
                return NotFound();
            }

            return View(animalCategories);
        }

        // POST: AnimalCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var animalCategories = await _context.AnimalCategories.FindAsync(id);
            if (animalCategories != null)
            {
                _context.AnimalCategories.Remove(animalCategories);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnimalCategoriesExists(int id)
        {
            return _context.AnimalCategories.Any(e => e.CategoryID == id);
        }
    }
}
