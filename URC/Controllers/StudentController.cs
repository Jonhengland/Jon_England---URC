using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using URC.Areas.Identity.Data;
using URC.Data;
using URC.Models;

namespace URC.Controllers
{
    public class StudentController : Controller
    {
        private readonly URCContext _context;
        private readonly UserManager<URCUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public StudentController(URCContext context, UserManager<URCUser> um, RoleManager<IdentityRole> rm)
        {
            _context = context;
            userManager = um;
            roleManager = rm;
        }

        // GET: Student
        public async Task<IActionResult> Index()
        {
            return View(await _context.Applications.ToListAsync());
        }



        [Authorize(Roles = "Administrator, Professor, Student")]
        public async Task<IActionResult> Application()
        {
            // Find the student's application, put it in a list
            var applications = await _context.Applications.ToListAsync();
            var user = await userManager.FindByNameAsync(User.Identity.Name);

            if (await userManager.IsInRoleAsync(user, "Professor"))
            {
                var activeApplications = applications.Where(a => a.Active);
                return View(activeApplications);
            }
            else if (await userManager.IsInRoleAsync(user, "Administrator"))
            {
                return View(applications);
            }
            else // User is a student
            {
                var studentsApp = applications.Where(a => a.Email.Equals(user.Email));
                return View(studentsApp);
            }

        }

        [Authorize(Roles = "Administrator, Professor")]
        public IActionResult Search()
        {
            return View();
        }

        // GET: Student/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Applications
                .FirstOrDefaultAsync(m => m.ID == id);

            if (application == null)
            {
                return NotFound();
            }
            
            if (User.IsInRole("Student"))
            {
                var applicationOwner = await userManager.FindByEmailAsync(application.Email);
                if (applicationOwner.UserName != User.Identity.Name)
                {
                    return NotFound();
                }
            }

            return View(application);
        }

        // GET: Student/Create
        [Authorize(Roles = "Student")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Email,Resume,ExpectedGradDate,DegreePlan,GPA,UID,HoursPerWeek,PersonalStatement,ApplicationDate,Active")] Application application)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(User.Identity.Name);
                application.Email = user.Email;
                application.Active = false;
                _context.Add(application);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(application);
        }

        // GET: Student/Edit/5
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Applications.FindAsync(id);
            var applicationOwner = await userManager.FindByEmailAsync(application.Email);

            if (applicationOwner.UserName != User.Identity.Name)
            {
                return NotFound();
            }

            if (application == null)
            {
                return NotFound();
            }
            return View(application);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Email,Resume,ExpectedGradDate,DegreePlan,GPA,UID,HoursPerWeek,PersonalStatement,ApplicationDate,Active")] Application application)
        {
            if (id != application.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    application.ApplicationDate = DateTime.Now;
                    _context.Update(application);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationExists(application.ID))
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
            return View(application);
        }

        // GET: Student/Delete/5
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Applications
                .FirstOrDefaultAsync(m => m.ID == id);

            var applicationOwner = await userManager.FindByEmailAsync(application.Email);

            if (applicationOwner.UserName != User.Identity.Name)
            {
                return NotFound();
            }

            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var application = await _context.Applications.FindAsync(id);
            _context.Applications.Remove(application);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplicationExists(int id)
        {
            return _context.Applications.Any(e => e.ID == id);
        }

        [HttpPost]
        public async Task<JsonResult> Find(string desiredSkills)
        {
            if (desiredSkills == null)
            {
                return Json(new object[0]);
            }

            List<string> skillList = desiredSkills.Split(", ").ToList();

            List<Application> applications = await _context.Applications.ToListAsync();
            List<Application> matches = new List<Application>();

            foreach (Application app in applications)
            {

                List<StudentSkill> skillsInApp = _context.StudentSkills.Where(s => s.ApplicationID == app.ID).ToList();

                foreach (StudentSkill ss in skillsInApp)
                {
                    if (skillList.Contains(ss.Skill))
                    {
                        matches.Add(app);
                        break;
                    }
                }
            }

            dynamic[] studentSummaryArray = new dynamic[matches.Count];

            for (int i = 0; i < studentSummaryArray.Length; i++)
            {
                var user = await userManager.FindByEmailAsync(matches[i].Email);
                studentSummaryArray[i] = new
                {
                    AppID = matches[i].ID,
                    Name = user.UserName,
                    UID = matches[i].UID,
                    GPA = matches[i].GPA.ToString(),
                    Skills = BuildSkills(matches[i].Skills),
                    StatementSummary = SummarizePersonalStatement(matches[i].PersonalStatement)
                };
            }

            var json = Json(studentSummaryArray);
            var jsonResult = json.Value;
            return Json(studentSummaryArray);

        }

        private string BuildSkills(ICollection<StudentSkill> skills)
        {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < skills.Count - 1; i++)
            {
                sb.Append(skills.ElementAt(i).Skill + ", ");
            }
            sb.Append(skills.ElementAt(skills.Count - 1).Skill);

            return sb.ToString();
        }


        private string SummarizePersonalStatement(string personalStatement)
        {
            string[] statementTokens = personalStatement.Split(' ');
            StringBuilder builder = new StringBuilder();

            int limit = (statementTokens.Length >= 100 ? 100 : statementTokens.Length);
            for (int i = 0; i < limit - 1; i++)
            {
                builder.Append(statementTokens[i] + " ");
            }
            builder.Append(statementTokens[limit - 1]);
            return builder.ToString();
        }

        [HttpPost]
        public async Task<IActionResult> Apply(string user_email, string activate_deactivate)
        {

            if (activate_deactivate.Equals("activate"))
            {
                var application = await _context.Applications.FirstOrDefaultAsync(m => m.Email == user_email);
                application.Active = true;
                _context.Applications.Update(application);
                _context.SaveChanges();

                return Ok(new { success = true, message = "activated!" });
            }
            else if (activate_deactivate.Equals("deactivate"))
            {

                var application = await _context.Applications.FirstOrDefaultAsync(m => m.Email == user_email);
                application.Active = false;
                _context.Applications.Update(application);
                _context.SaveChanges();

                return Ok(new { success = true, message = "deactivated!" });
            }
            else
            {
                // fails
                return BadRequest(new { success = false, message = "bad request" });
            }
        }
    }


}
