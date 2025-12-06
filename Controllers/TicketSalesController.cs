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
    public class TicketSalesController : Controller
    {
        private readonly ZooAndAnimalFunContext _context;

        public TicketSalesController(ZooAndAnimalFunContext context)
        {
            _context = context;
        }

        // GET: TicketSales
        public async Task<IActionResult> Index()
        {
            return View(await _context.TicketSales.ToListAsync());
        }

        // GET: TicketSales/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticketSales = await _context.TicketSales
                .FirstOrDefaultAsync(m => m.TicketID == id);
            if (ticketSales == null)
            {
                return NotFound();
            }

            return View(ticketSales);
        }

        // GET: TicketSales/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TicketSales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TicketID,price,CustomerID,DateSold,ApplicableFor,TicketTypeID,SessionID")] TicketSales ticketSales)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ticketSales);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ticketSales);
        }

        // GET: TicketSales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticketSales = await _context.TicketSales.FindAsync(id);
            if (ticketSales == null)
            {
                return NotFound();
            }
            return View(ticketSales);
        }

        // POST: TicketSales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("TicketID,price,CustomerID,DateSold,ApplicableFor,TicketTypeID,SessionID")] TicketSales ticketSales)
        {
            if (id != ticketSales.TicketID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ticketSales);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketSalesExists(ticketSales.TicketID))
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
            return View(ticketSales);
        }

        // GET: TicketSales/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticketSales = await _context.TicketSales
                .FirstOrDefaultAsync(m => m.TicketID == id);
            if (ticketSales == null)
            {
                return NotFound();
            }

            return View(ticketSales);
        }

        // POST: TicketSales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ticketSales = await _context.TicketSales.FindAsync(id);
            if (ticketSales != null)
            {
                _context.TicketSales.Remove(ticketSales);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketSalesExists(string id)
        {
            return _context.TicketSales.Any(e => e.TicketID == id);
        }
    }
}
