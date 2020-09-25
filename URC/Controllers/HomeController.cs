/*
Author: Peter Forsling
Date: 24 September 2020
Course: CS 4540, University of Utah, School of Computing
Copyright: CS 4540 and Peter Forsling - This work may not be copied for use in Academic Coursework.

I, Peter Forsling, certify that I wrote this code from scratch and did not copy it in part or whole from
another source. Any references used in the completion of the assignment are cited in my README file.

File Contents
This file contains the Home Controller
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using URC.Data;
using URC.Models;

namespace URC.Controllers
{
    /// <summary>
    /// The Home Controller
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        /// <summary>
        /// The URC Database
        /// </summary>
        private readonly URCContext _context;

        public HomeController(ILogger<HomeController> logger, URCContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // The featured opportunities to be listed on the home page. As of right now, 
            // It is just taking the first three results found in the database. But this
            // statement may be updated in the future to represent something more meaningful,
            // like most recent, or most viewed.
            var featuredOpps = await _context.Opportunities.ToListAsync();

            return View(featuredOpps);
        }

        public IActionResult Handmade_Details()
        {
            return View();
        }

        public IActionResult Handmade_Opportunities()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
