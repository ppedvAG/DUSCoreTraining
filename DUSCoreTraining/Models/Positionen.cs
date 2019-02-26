using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DUSCoreTraining.Models
{
    public class Positionen
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int RechnungID { get; set; }
        public int Anzahl { get; set; }
        public string Text { get; set; }
        public float Preis { get; set; }
        virtual public Rechnung Rechnung { get; set; }
    }
}
