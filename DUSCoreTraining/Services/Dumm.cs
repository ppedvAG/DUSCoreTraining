using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUSCoreTraining.Services
{
    public class Dumm : IDumm
    {
        public Dumm(IDumm dumm)
        {

        }
        public int MyProperty { get; set; }
    }
}
