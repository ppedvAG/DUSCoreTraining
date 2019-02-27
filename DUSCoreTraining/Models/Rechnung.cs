using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DUSCoreTraining.Models
{

    public class Rechnung
    {
        public Rechnung()
        {
            Positionen = new List<Positionen>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime Datum { get; set; }
        public string KopfText { get; set; }
        public int KundenID { get; set; }
        public float Summe { get; set; }
        virtual public IEnumerable<Positionen> Positionen { get; set; }
    }
}
