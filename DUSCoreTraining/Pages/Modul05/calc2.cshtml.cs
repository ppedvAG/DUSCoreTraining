using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DUSCoreTraining.Pages.Modul05
{
    public class calc2Model : PageModel
    {
        public int Ergebnis { get; set; }
        public void OnGet()
        {

        }
        public void OnPostAdd()
        {
            Ergebnis =int.Parse( HttpContext.Request.Form["eins"]) +
                int.Parse(HttpContext.Request.Form["zwei"]);
        }

        public void OnGPostSub([FromForm]int eins, [FromForm] int zwei)
        {
            Ergebnis = eins - zwei;

        }
    }
}