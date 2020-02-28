using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class GUI
    {
        //Main Gui'en den masn først ser når man åbner programmet
        public static void mainAutomatGui(int Mønter)
        {
            ValgAutomat idVare = new ValgAutomat();
            Betaling penge = new Betaling(Mønter);

            Console.Clear();
            Console.WriteLine("[-------------------------------------------------]");
            Console.WriteLine("                     Automaten"                      );
            Console.WriteLine("[-------------------------------------------------]");
            Console.WriteLine($"du har: { penge.Penge} kr\n");
            //En foreach til at skrive hele listen
            foreach (var item in Automat.nyVare)
            {
                Console.WriteLine($"|ID: {item.VareID}| |Varenavn: {item.VareNavn}| |Pris: {item.VarePris} kr.| |Vare Tilbage {item.VareAntal}|\n");
            }
            //til at vælge ens produkt
            Console.Write("Choose your Product by id: ");
            idVare.ValgVare = Int32.Parse(Console.ReadLine());
            error_Messages.idError(idVare.ValgVare, penge.Penge);
            GUI.betalingGui(idVare.ValgVare, penge.Penge);
        }

        //Gui til betalings systemet
        public static void betalingGui(int vare, int penge)
        {
            Console.Clear();
            Console.WriteLine("[-------------------------------------------------]");
            Console.WriteLine("                      Betaling");
            Console.WriteLine("[-------------------------------------------------]\n");
            Console.WriteLine("ID på dit produk: " + vare);

            //refering over til resten af min text
            Betaling.betalingen(vare, penge);

        }
    }
}
