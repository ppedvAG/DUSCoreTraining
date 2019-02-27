using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DUSCoreTraining.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DUSCoreTraining.Pages.Modul08
{
   
    public class EditAutoModel : PageModel
    {
        [BindProperty]
        public Auto MyAuto { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();

            }
           
            ModelState.Clear();
            //Response.Redirect(".");
            return Page();
        }
    }
}