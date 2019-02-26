using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DUSCoreTraining.Models;

namespace DUSCoreTraining.Pages.Modul07
{
    public class CreateModel : PageModel
    {
        private readonly DUSCoreTraining.Models.ModelRechnung _context;

        public CreateModel(DUSCoreTraining.Models.ModelRechnung context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Rechnung Rechnung { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Rechnungs.Add(Rechnung);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}