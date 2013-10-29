using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract
{
    class Room
    {
        public Tuple<int, int> Size; // Width & Length
        public Wallpaper Wallpaper;

        public List<Meuble> Meubles;
    }
}
