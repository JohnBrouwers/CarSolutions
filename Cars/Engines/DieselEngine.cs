using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Engines
{
    public class DieselEngine: Engine
    {
        private const string dieselSound = "prut";
        public DieselEngine() : base(dieselSound)
        {

        }
    }
}
