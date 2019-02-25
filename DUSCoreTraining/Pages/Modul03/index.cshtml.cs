using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DUSCoreTraining.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DUSCoreTraining.Pages.Modul03
{
    public class indexModel : PageModel
    {
        public int Anzahl { get; set; }
        public void OnGet([FromServices] Dumm requestcounter)
        {
            requestcounter.MyProperty++;
            Anzahl = requestcounter.MyProperty;
        }
    }
}