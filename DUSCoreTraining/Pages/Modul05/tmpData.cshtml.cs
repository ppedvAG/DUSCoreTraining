using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DUSCoreTraining.Pages.Modul05
{
    public class tmpDataModel : PageModel
    {
        public void OnGet()
        {
            TempData["Punkte"] = 2;
            var x = TempData["Punkte"]; // Tempdata leer
            var y = TempData.Peek("Punkte"); //Wert bleibt erhalten


        }
    }
}