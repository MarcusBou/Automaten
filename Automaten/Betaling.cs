using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Betaling
    {
        private int betal;
        private int penge;
        public int Betal { set { betal = value; } get { return betal; } }
        public int Penge { set { penge = value; } get { return penge; } }

        public Betaling()
        {

        }
        public Betaling(int Pengene)
        {
            this.penge = Pengene;
        }

        public static void betalingen(int vareValg, int penge)
        {
            //out puttet til om du vil købe produktet
            Betaling betalnu = new Betaling(penge);
            foreach (var item in Automat.nyVare)
            {
                if(item.VareID == vareValg)
                {
                    Console.WriteLine($"|{item.VareNavn}| |til: {item.VarePris} kr.| ");
                    Console.WriteLine(item.VarePris);
                    Console.Write("Ønsker du at fortsætte købet, ja eller nej: ");
                    string fortsæt = Console.ReadLine();
                    if (fortsæt == "ja")
                    {
                        //vis ja bliver man videre sent igennem en error tjekker, og så får man så sin vare, vis man er godkendt, vis man siger nej gå man tilbage til menuen
                        error_Messages.ErrorOccured(item.VarePris, betalnu.penge, item.VareAntal);
                        betalnu.betalNu(item.VarePris);
                        item.VareAntal = item.VareAntal - 1;
                        Console.WriteLine("______________________________________________");
                        Console.WriteLine("\n Her er din " + item.VareNavn);
                        Console.ReadKey();
                        GUI.mainAutomatGui(betalnu.penge);
                    }
                    else
                    {
                        GUI.mainAutomatGui(betalnu.penge);
                    }
                }
            }
        }

        public int betalNu(int varepris)
        {
            //til at fjerne beløbet man har betalt
            return this.Penge = this.penge - varepris;
        }
    }
}
