using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DUSCoreTraining.Models;

namespace DUSCoreTraining.Pages.Modul07
{
    public class EditModel : PageModel
    {
        private readonly DUSCoreTraining.Models.ModelRechnung _context;

        public EditModel(DUSCoreTraining.Models.ModelRechnung context)
        {
            _context = context;
        }

        [BindProperty]
        public Rechnung Rechnung { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rechnung = await _context.Rechnungs.FirstOrDefaultAsync(m => m.ID == id);

            if (Rechnung == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Rechnung).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RechnungExists(Rechnung.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RechnungExists(int id)
        {
            return _context.Rechnungs.Any(e => e.ID == id);
        }
    }
}
