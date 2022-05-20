using Drag_and_Drop.DATA;
using Drag_and_Drop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drag_and_Drop.Controllers
{
    public class Doctor_StaffController : Controller
    {
        public readonly ApplicationDBContext dbcontext;

        public Doctor_StaffController(ApplicationDBContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PateintDetails()
        {
            var en = dbcontext.Add_Pateint.ToList();
            return View(en);
        }
        public IActionResult Show(int? id)
        {
            var emp = dbcontext.Add_Pateint.ToList();
            if (id != null)
            {
                emp = emp.Where(x => x.ID == id).ToList();
            }
            return new JsonResult(emp);
        }

        public IActionResult Create_Patient()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create_Patient([FromBody] Add_Pateint obj)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult("input field can't be empty");
            }
            dbcontext.Add_Pateint.Add(obj);
            dbcontext.SaveChanges();
            return new JsonResult(obj);
        }
    }
}
