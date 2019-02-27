using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DUSCoreTraining.Pages.Modul08
{
    public class ModelStatusModel : PageModel
    {
        [BindProperty]
        public string Feld { get; set; }
        [BindProperty]
        public string Feld2 { get; set; }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            ModelState.Remove("Feld2");
           // Feld = "irgendwas";
            Feld2 = "neuer Wert";
            ModelState.Clear();
        }
    }
}