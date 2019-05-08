using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StudentExercisesApi.Controllers
{
    public class StudentExerciseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}