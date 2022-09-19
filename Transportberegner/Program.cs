using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Transportberegner;

namespace Transportberegner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transportprisberegner");
            Console.Write("Indtast afstanden til destinationen (km): ");
            int afstandTilDestinationen = Int32.Parse(Console.ReadLine());
            Console.Write("Indtast vægt (kg): ");
            int varensVaegt = Int32.Parse(Console.ReadLine());

            var transportprisObject = new IBeregner();

            int transportpris = transportprisObject.BeregnTransportpris(afstandTilDestinationen, varensVaegt);

            Console.WriteLine("Prisen er "+transportpris+" kr.");
            Console.ReadLine();
        }

        
    }
}
