using Cars.Engines;
using System;

namespace Cars
{
    public class Car<TEngine> where TEngine: Engine, new()
    {
        private readonly TEngine engine = null;

        public Car()
        {
            this.engine = new TEngine();
        }

        public string Start() => engine.Start();
    }
}
