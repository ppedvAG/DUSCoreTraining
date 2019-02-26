using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DUSCoreTraining.Pages.Modul05
{
    public class SessVarModel : PageModel
    {
        public void OnGet()
        {
            HttpContext.Session.SetString("names", "Hannes");
         
        }
    }
}