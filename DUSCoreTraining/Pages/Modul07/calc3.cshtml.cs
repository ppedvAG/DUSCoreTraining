using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DUSCoreTraining.Pages.Modul07
{
    public class calc3Model : PageModel
    {
        public int Ergebnis { get; set; }
        [BindProperty]
        public int eins { get; set; }
        [BindProperty]
        public int zwei { get; set; }
        public void OnGet()
        {

        }
        public void OnPostAdd()
        {
            Ergebnis = eins + zwei;
        }

        public void OnPostSub()
        {
            Ergebnis = eins - zwei;

        }
    }
}