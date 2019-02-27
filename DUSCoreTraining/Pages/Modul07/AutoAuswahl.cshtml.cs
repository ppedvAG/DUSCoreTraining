using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DUSCoreTraining.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace DUSCoreTraining.Pages.Modul07
{
    public class AutoAuswahlModel : PageModel
    {
        public List<Auto> MyAutos { get; set; }
        public List<SelectListItem> MyItems { get; set; }
        [BindProperty]
        public string Auswahl { get; set; }
        public void OnGet()
        {
            var pfad = @"C:\aspnetcore\training\DUSCoreTraining\DUSCoreTraining\wwwroot\app_data\json.json";
            var json = System.IO.File.ReadAllText(pfad);
            MyAutos = JsonConvert.DeserializeObject<Autos>(json).Auto.ToList();
            var q = MyAutos.Select(a => new SelectListItem() { Text = a.Marke, Value = a.Marke });

            var qq = from a in MyAutos
                     orderby a.Marke
                     select new SelectListItem
                     {
                         Text = a.Marke,
                         Value = a.Marke
                     };
            MyItems = qq.ToList();

        } 
    }
}