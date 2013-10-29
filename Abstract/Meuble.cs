using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract
{
    abstract class Meuble
    {
        private string _material;
        private int _weight;

        public string getMaterial() { return _material; }
        public int getWeight() { return _weight; }

        public abstract void fall();
    }
}
