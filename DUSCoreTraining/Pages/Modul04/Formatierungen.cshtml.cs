﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DUSCoreTraining.Pages.Modul04
{
    public class FormatierungenModel : PageModel
    {
        public DateTime Datum { get; set; }
        public void OnGet()
        {
            Datum = DateTime.Now;

        }
    }
}