using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DUSCoreTraining.Pages.Modul05
{
    public class DateiUploadModel : PageModel
    {
        public void OnGet()
        {

        }
        public void OnPost(IFormFile datei)
        {
            var pfad = @"C:\aspnetcore\training\DUSCoreTraining\DUSCoreTraining\wwwroot\app_data\";
            pfad = Path.Combine(AppDomain.CurrentDomain.GetData("wwwpath").ToString(), datei.FileName);
            using (var fs = new FileStream(pfad,FileMode.Create))
            {
                datei.CopyTo(fs);

            }

        }
    }
}