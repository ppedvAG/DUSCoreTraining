using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DUSCoreTraining.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DUSCoreTraining.Pages.Modul08
{
    public class Lab1Model : PageModel
    {
        private readonly DUSCoreTraining.Models.ModelRechnung _context;

       

        public Lab1Model(DUSCoreTraining.Models.ModelRechnung context)
        {
            _context = context;
        }
        public List<Rechnung> Rechnungen { get; set; }
        public void OnGet()
        {
         //   var ef = new ModelRechnung();
            Rechnungen = _context.Rechnungs
                .Include(p => p.Positionen).ToList();

        }
    }
}