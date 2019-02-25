using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DUSCoreTraining.Pages.Modul03
{
    public class PageMethodeModel : PageModel
    {
        public void OnGet()
        {
            var x = Request.Query["id"];




        }
      
        public void OnGetDrucken([FromRoute] string id)
        {
            //[FromQuery] string id

        }
        //short [FromForm] string id) wie Input name
        public void OnPost([FromForm(Name ="id")] string myId)
        {
          var x=  Request.Form["id"];

        }
    }
}