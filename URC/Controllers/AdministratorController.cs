/*
Author: Peter Forsling
Date: 12 October 2020
Course: CS 4540, University of Utah, School of Computing
Copyright: CS 4540 and Peter Forsling - This work may not be copied for use in Academic Coursework.

I, Peter Forsling, certify that I wrote this code from scratch and did not copy it in part or whole from
another source. Any references used in the completion of the assignment are cited in my README file.

File Contents
This file contains code for the administrator controller
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using URC.Areas.Identity.Data;

namespace URC.Controllers
{
    public class AdministratorController : Controller
    {

        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<URCUser> userManager;

        public AdministratorController(RoleManager<IdentityRole> rm, UserManager<URCUser> um)
        {
            roleManager = rm;
            userManager = um;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult RoleTable()
        {
            ViewData["um"] = userManager.Users.ToArray();
            ViewData["rm"] = roleManager;

            return View();
        }


        //user_id: user_id, old_role: oldRole, role: new_role, add_remove: addRemove
        [HttpPost]
        public async Task<IActionResult> Post(string user_id, string old_role, string role, string add_remove)
        {
            var user = await userManager.FindByIdAsync(user_id);
            if (user != null)
            {
                if (add_remove.Equals("add"))
                {
                    // role has not been assigned yet
                    if (userManager.GetRolesAsync(user).Result.Count < 1)
                    {
                        await userManager.AddToRoleAsync(user, role);
                        return Ok(new { success = true, message = "added!" });
                    }
                    // role has been assigned and needs to be replaced
                    await userManager.RemoveFromRoleAsync(user, old_role);
                    await userManager.AddToRoleAsync(user, role);
                    return Ok(new { success = true, message = "added!" });
                }
                // role is being removed
                else
                {
                    await userManager.RemoveFromRoleAsync(user, old_role);
                    return Ok(new { success = true, message = "removed!" });
                }
            }
            // fails
            return BadRequest(new { success = false, message = "bad request" });
        }

    }
}
