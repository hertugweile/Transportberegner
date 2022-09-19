using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportberegner
{
    public class IBeregner
    {
        public int BeregnTransportpris(int afstand, int vaegt)
        {
            int transportpris;
            if (afstand < 5 && vaegt < 10)
            {
                transportpris = 0;
            }
            else if (afstand < 5 && vaegt >= 10)
            {
                transportpris = 50;
            }
            else if (afstand >= 5 && vaegt < 10)
            {
                transportpris = 75;
            }
            else
            {
                transportpris = 100;
            }
            return transportpris;
        }
    }
}
