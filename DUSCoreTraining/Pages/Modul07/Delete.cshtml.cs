using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DUSCoreTraining.Models;

namespace DUSCoreTraining.Pages.Modul07
{
    public class DeleteModel : PageModel
    {
        private readonly DUSCoreTraining.Models.ModelRechnung _context;

        public DeleteModel(DUSCoreTraining.Models.ModelRechnung context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rechnung = await _context.Rechnungs.FindAsync(id);

            if (Rechnung != null)
            {
                _context.Rechnungs.Remove(Rechnung);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
