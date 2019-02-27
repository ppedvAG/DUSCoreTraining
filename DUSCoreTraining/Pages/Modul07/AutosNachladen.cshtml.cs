using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DUSCoreTraining.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace DUSCoreTraining.Pages.Modul07
{
    public class AutosNachladenModel : PageModel
    {

        public void OnGet()
        {

        }
        public List<Auto> MyAutos { get; set; }
        public PartialViewResult OnGetLoadAutos()
        {
            var pfad = @"C:\aspnetcore\training\DUSCoreTraining\DUSCoreTraining\wwwroot\app_data\json.json";
            var json = System.IO.File.ReadAllText(pfad);
            MyAutos = JsonConvert.DeserializeObject<Autos>(json).Auto.ToList();
            return Partial("_AutosNachladenPartial",this);
        }
    }
}