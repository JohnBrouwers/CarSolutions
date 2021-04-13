using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Engines
{
    public abstract class Engine
    {
        protected readonly string sound = string.Empty;
        public string Start() => sound;

        protected Engine(string sound) => this.sound = sound;
    }
}
