using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using URC.Areas.Identity.Data;
using URC.Data;
using URC.Models;

namespace URC.Controllers
{
    public class APIController : Controller
    {
        private URCContext _context;
        private UserManager<URCUser> userManager;

        public APIController(URCContext context, UserManager<URCUser> um)
        {
            _context = context;
            userManager = um;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Ping()
        {
            return new JsonResult(new { message = "Hello it is me, the server." });
        }



       
    }
}
