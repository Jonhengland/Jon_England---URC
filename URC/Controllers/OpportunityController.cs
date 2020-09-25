/*
Author: Peter Forsling
Date: 24 September 2020
Course: CS 4540, University of Utah, School of Computing
Copyright: CS 4540 and Peter Forsling - This work may not be copied for use in Academic Coursework.

I, Peter Forsling, certify that I wrote this code from scratch and did not copy it in part or whole from
another source. Any references used in the completion of the assignment are cited in my README file.

File Contents
This file contains the Opportunity Controller.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using URC.Data;
using URC.Models;

namespace URC.Controllers
{
    /// <summary>
    /// The Opportunity Controller
    /// </summary>
    public class OpportunityController : Controller
    {
        /// <summary>
        /// The URC database
        /// </summary>
        private readonly URCContext _context;

        public OpportunityController(URCContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Opportunities and their tags
            var oppTagList = await _context.Opportunities.Include(o => o.Tags).AsNoTracking().ToListAsync();

            return View(oppTagList);
        }


        // GET: Opportunity
        public async Task<IActionResult> List()
        {
            return View(await _context.Opportunities.ToListAsync());
        }


        public async Task<IActionResult> OpportunityDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Opportunity with the corresponding skills and tags
            var oppTagsSkills = await _context.Opportunities
                .Include(o => o.Tags)
                .Include(o => o.RequiredSkills)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.OpportunityID == id);

            if (oppTagsSkills == null)
            {
                return NotFound();
            }

            return View(oppTagsSkills);
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opportunity = await _context.Opportunities
                .Include(o => o.Tags)
                .Include(o => o.RequiredSkills)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.OpportunityID == id);

            if (opportunity == null)
            {
                return NotFound();
            }
            return View();
        }


        // GET: Opportunity/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opportunity = await _context.Opportunities
                .FirstOrDefaultAsync(m => m.OpportunityID == id);
            if (opportunity == null)
            {
                return NotFound();
            }

            return View(opportunity);
        }

        // GET: Opportunity/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Opportunity/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OpportunityID,ProjectName,ProfessorName,ProjectDescription,Image,MentorName,BeginDate,EndDate,Pay,Filled")] Opportunity opportunity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(opportunity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(opportunity);
        }

        // GET: Opportunity/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opportunity = await _context.Opportunities.FindAsync(id);
            if (opportunity == null)
            {
                return NotFound();
            }
            return View(opportunity);
        }

        // POST: Opportunity/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OpportunityID,ProjectName,ProfessorName,ProjectDescription,Image,MentorName,BeginDate,EndDate,Pay,Filled")] Opportunity opportunity)
        {
            if (id != opportunity.OpportunityID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(opportunity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OpportunityExists(opportunity.OpportunityID))
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
            return View(opportunity);
        }

        // GET: Opportunity/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opportunity = await _context.Opportunities
                .FirstOrDefaultAsync(m => m.OpportunityID == id);
            if (opportunity == null)
            {
                return NotFound();
            }

            return View(opportunity);
        }

        // POST: Opportunity/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var opportunity = await _context.Opportunities.FindAsync(id);
            _context.Opportunities.Remove(opportunity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OpportunityExists(int id)
        {
            return _context.Opportunities.Any(e => e.OpportunityID == id);
        }
    }
}
