using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index(){
            var kurs = new Course
            {
                Id = 1,
                Title = "Aspnet core kursu",
                Description = "Güzel bir kurs"
            };

            return View(kurs);
        }

        public IActionResult List(){
            return View();
        }

        
    }
}