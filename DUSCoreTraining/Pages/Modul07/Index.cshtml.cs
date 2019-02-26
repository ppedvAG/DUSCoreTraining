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
    public class IndexModel : PageModel
    {
        private readonly DUSCoreTraining.Models.ModelRechnung _context;

        public IndexModel(DUSCoreTraining.Models.ModelRechnung context)
        {
            _context = context;
        }

        public IList<Rechnung> Rechnung { get;set; }

        public async Task OnGetAsync()
        {
            Rechnung = await _context.Rechnungs.ToListAsync();
        }
    }
}
