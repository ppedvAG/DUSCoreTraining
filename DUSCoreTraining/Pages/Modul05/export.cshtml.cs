using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DUSCoreTraining.Pages.Modul05
{
    public class exportModel : PageModel
    {
        public void OnGet()
        {
            HttpContext.Response.ContentType = "application/vnd.ms-excel";
        }
    }
}