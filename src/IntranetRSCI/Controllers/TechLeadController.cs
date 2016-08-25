using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IntranetRSCI.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace IntranetRSCI.Controllers
{
    public class TechLeadController : Controller
    {

        private IntranetRSCIContext _context;

        public TechLeadController(IntranetRSCIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TechLead techLead)
        {
            if(ModelState.IsValid)
            {
                techLead.DateAdded = DateTime.Now;
                _context.TechLeads.Add(techLead);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Error");
        }
    }
}
