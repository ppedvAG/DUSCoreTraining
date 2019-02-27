using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DUSCoreTraining.Models
{
   

    public class Autos
    {
        public Auto[] Auto { get; set; }
    }

    public class Auto
    {

        public string Marke { get; set; }
        public Boolean Wahl { get; set; }
        [Display(Description ="Baujahre")]
        [Range(1920,2020,ErrorMessage ="Pferd reiten")]
        public int Jahre { get; set; }
        [EmailAddress()]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string passwort { get; set; }
    }

}
