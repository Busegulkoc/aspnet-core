using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers
{
    public class CourseController : Controller
    {
        public string Index(){
            return "course/index";
        }

        public string List(){
            return "course/list";
        }

        
    }
}