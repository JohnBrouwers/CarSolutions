using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Engines
{
    public class ElectricEngine: Engine
    {
        private const string electricSound = "zoom";

        public ElectricEngine() : base(electricSound)
        {

        }
    }
}
