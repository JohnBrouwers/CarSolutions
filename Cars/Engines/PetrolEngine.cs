using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Engines
{
    public class PetrolEngine: Engine
    {
        private const string petrolSound = "vroom";
        public PetrolEngine() : base(petrolSound)
        {

        }
    }
}
