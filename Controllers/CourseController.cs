using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using basics.Models;
using Microsoft.AspNetCore.Components.Web;
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
                Description = "Güzel bir kurs",
                Image="1.jpg"
            };

            return View(kurs);
        }

        public IActionResult List(){
        var kurslar = new List<Course>()
        {
            new Course(){Id = 1, Title= "aspnet kursu" , Description="güzel bir kurs", Image= "1.jpg"},
            new Course(){Id = 2, Title= "php kursu" , Description="güzel bir kurs", Image= "2.jpg"},
            new Course(){Id = 3, Title= "js kursu" , Description="güzel bir kurs",  Image= "3.jpg"},

        };
            return View("list", kurslar);
        }

        
    }
}