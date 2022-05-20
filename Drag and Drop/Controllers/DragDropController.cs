using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drag_and_Drop.Controllers
{
    public class DragDropController : Controller
    {
        public IActionResult Drag()
        {
            
            return View();
        }

        public IActionResult Table()
        {
            return View();
        }

        public IActionResult Demo()
        {
            return View();
        }
    }
}
