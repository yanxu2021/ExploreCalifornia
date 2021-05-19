using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExploreCalifornia.Data;
using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Authorization;

namespace ExploreCalifornia.Controllers
{
    public class JourneysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JourneysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Journeys
        public async Task<IActionResult> Index()
        {
            return View(await _context.Journey.ToListAsync());
        }

        // GET: Journeys/Search
        public async Task<IActionResult> Search()
        {
            return View();
        }

        //POST : Journeys/ShowSearchResults
        public async Task<IActionResult> ShowSearchResults(String SearchPhrase)
        {
            return View("Index",await _context.Journey.Where(j => j.JourneyTitle.Contains(SearchPhrase)).ToListAsync());
        }

        // GET: Journeys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var journey = await _context.Journey
                .FirstOrDefaultAsync(m => m.Id == id);
            if (journey == null)
            {
                return NotFound();
            }

            return View(journey);
        }

        [Authorize]
        // GET: Journeys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Journeys/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,JourneyTitle,Address")] Journey journey)
        {
            if (ModelState.IsValid)
            {
                _context.Add(journey);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(journey);
        }

        [Authorize]
        // GET: Journeys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var journey = await _context.Journey.FindAsync(id);
            if (journey == null)
            {
                return NotFound();
            }
            return View(journey);
        }

        // POST: Journeys/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,JourneyTitle,Address")] Journey journey)
        {
            if (id != journey.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(journey);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JourneyExists(journey.Id))
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
            return View(journey);
        }

        [Authorize]
        // GET: Journeys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var journey = await _context.Journey
                .FirstOrDefaultAsync(m => m.Id == id);
            if (journey == null)
            {
                return NotFound();
            }

            return View(journey);
        }

        // POST: Journeys/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var journey = await _context.Journey.FindAsync(id);
            _context.Journey.Remove(journey);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JourneyExists(int id)
        {
            return _context.Journey.Any(e => e.Id == id);
        }
    }
}
