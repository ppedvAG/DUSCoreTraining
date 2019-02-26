using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DUSCoreTraining.Pages.Modul03
{
    public class calcModel : PageModel
    {
        public int Ergebnis { get; set; }
        public void OnGet()
        {
          
        }
        public void OnGetAdd([FromQuery]int eins, [FromQuery] int zwei)
        {
            Ergebnis = eins + zwei;
        }

                public void OnGetSub([FromQuery]int eins, [FromQuery] int zwei)
        {
            Ergebnis = eins - zwei;
        }
    }

}