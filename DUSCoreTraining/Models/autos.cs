using System;
using System.Collections.Generic;
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
    }

}
