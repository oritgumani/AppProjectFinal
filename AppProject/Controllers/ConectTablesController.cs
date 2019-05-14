using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppProject.Models;

namespace AppProject.Controllers
{
    public class ConectTablesController : Controller
    {
        private readonly AppProjectContext _context;

        public ConectTablesController(AppProjectContext context)
        {
            _context = context;
        }

        // GET: ConectTables
        public async Task<IActionResult> Index()
        {
            var appProjectContext = _context.ConectTable.Include(c => c.Colors).Include(c => c.Marts).Include(c => c.Products).Include(c => c.Sizes);
            return View(await appProjectContext.ToListAsync());
        }

        // GET: ConectTables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conectTable = await _context.ConectTable
                .Include(c => c.Colors)
                .Include(c => c.Marts)
                .Include(c => c.Products)
                .Include(c => c.Sizes)
                .SingleOrDefaultAsync(m => m.DetailesId == id);
            if (conectTable == null)
            {
                return NotFound();
            }

            return View(conectTable);
        }

        // GET: ConectTables/Create
        public IActionResult Create()
        {
            ViewData["ColorId"] = new SelectList(_context.Color, "ColorId", "ColorId");
            ViewData["MartId"] = new SelectList(_context.Mart, "MartId", "MartId");
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId", "ProductId");
            ViewData["SizeId"] = new SelectList(_context.Set<Size>(), "SizeId", "SizeId");
            return View();
        }

        // POST: ConectTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DetailesId,ProductId,SizeId,ColorId,MartId")] ConectTable conectTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(conectTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ColorId"] = new SelectList(_context.Color, "ColorId", "ColorId", conectTable.ColorId);
            ViewData["MartId"] = new SelectList(_context.Mart, "MartId", "MartId", conectTable.MartId);
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId", "ProductId", conectTable.ProductId);
            ViewData["SizeId"] = new SelectList(_context.Set<Size>(), "SizeId", "SizeId", conectTable.SizeId);
            return View(conectTable);
        }

        // GET: ConectTables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conectTable = await _context.ConectTable.SingleOrDefaultAsync(m => m.DetailesId == id);
            if (conectTable == null)
            {
                return NotFound();
            }
            ViewData["ColorId"] = new SelectList(_context.Color, "ColorId", "ColorId", conectTable.ColorId);
            ViewData["MartId"] = new SelectList(_context.Mart, "MartId", "MartId", conectTable.MartId);
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId", "ProductId", conectTable.ProductId);
            ViewData["SizeId"] = new SelectList(_context.Set<Size>(), "SizeId", "SizeId", conectTable.SizeId);
            return View(conectTable);
        }

        // POST: ConectTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DetailesId,ProductId,SizeId,ColorId,MartId")] ConectTable conectTable)
        {
            if (id != conectTable.DetailesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(conectTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConectTableExists(conectTable.DetailesId))
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
            ViewData["ColorId"] = new SelectList(_context.Color, "ColorId", "ColorId", conectTable.ColorId);
            ViewData["MartId"] = new SelectList(_context.Mart, "MartId", "MartId", conectTable.MartId);
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId", "ProductId", conectTable.ProductId);
            ViewData["SizeId"] = new SelectList(_context.Set<Size>(), "SizeId", "SizeId", conectTable.SizeId);
            return View(conectTable);
        }

        // GET: ConectTables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conectTable = await _context.ConectTable
                .Include(c => c.Colors)
                .Include(c => c.Marts)
                .Include(c => c.Products)
                .Include(c => c.Sizes)
                .SingleOrDefaultAsync(m => m.DetailesId == id);
            if (conectTable == null)
            {
                return NotFound();
            }

            return View(conectTable);
        }

        // POST: ConectTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var conectTable = await _context.ConectTable.SingleOrDefaultAsync(m => m.DetailesId == id);
            _context.ConectTable.Remove(conectTable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConectTableExists(int id)
        {
            return _context.ConectTable.Any(e => e.DetailesId == id);
        }
    }
}
