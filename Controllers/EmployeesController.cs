using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Garbarje.Data;
using Garbarje.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Garbarje.Controllers
{
    [Authorize(Roles = "Employee")]
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext db;

        public EmployeesController(ApplicationDbContext dbContext)
            {
            db = dbContext;
            }
        // GET: Employees
        public ActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
             var employee = db.Employees.Where(c => c.IdentityUserId ==
            userId).FirstOrDefault();

            return View();
           
        }

        // GET: Employees/Details/5
        public ActionResult Details(int id)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = db.Employees.Where(c => c.IdentityUserId ==
           userId).FirstOrDefault();

            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(db.Users, "Id", "Id");
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("EId,EmployeeFirstName,EmployeeLastName,EmployeeZipcode,IdentityUserId")] Employee employees)
        
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(Employee employee)
        {
            

           
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(db.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);

          
        }

        // POST: Employees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,Employee employee)
        {
            try
            {
                // TODO: Add update logic here
                db.Update(employee);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return NotFound();
            }
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null) 
            {
                return NotFound();

            }
            var employees = db.Employees
               .Include(c => c.IdentityUser)
               .FirstOrDefaultAsync(m => m.EId == id);
            if (employees == null)
            {
                return NotFound();
            }

            return View(employees);

            
        }

        // POST: Employees/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Employee employee)
        {
            try
            {
                // TODO: Add delete logic here
                db.Remove(employee);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                
                return NotFound();
            }
        }
    }
}