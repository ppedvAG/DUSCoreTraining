using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DUSCoreTraining.Pages.Modul03
{
    public class HannesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}