using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class error_Messages
    {
        public static void ErrorOccured(int varerpris, int penge, int varelager)
        {
            //de forskellige errors
            if(varelager <= 0)
            {
                Console.WriteLine("Dette produkt er ikke tilgængeligt");
                Console.ReadKey();
                GUI.mainAutomatGui(penge);
            }

            else if (penge < varerpris)
            {
                Console.WriteLine("Du har ikke puttet nok mønter i");
                Console.ReadKey();
                GUI.mainAutomatGui(penge);
            }
        }

        public static void idError(int idValg, int penge)
        {
            //Går igennem om ideen findes
            if (idValg > 22 || idValg < 11)
            {
                Console.Clear();
                Console.WriteLine("Dette er ikke en id der er brugbar");
                Console.ReadKey();
                GUI.mainAutomatGui(penge);
            }
        }
    }
}
