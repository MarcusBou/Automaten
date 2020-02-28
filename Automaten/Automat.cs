using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Automat
    {
        //Listen der viser hvad Automaten inholder, og hvor meget der tilbage
        public static List<Varer> nyVare = new List<Varer> {
        new Varer(11, "Cola", 20, 10), new Varer(12, "Pepsi", 19, 10), new Varer(13, "Fanta", 19, 10),
        new Varer(14, "Sprite", 18, 10), new Varer(15, "Faxe Kondi", 20, 10), new Varer(16, "Redbull", 15, 12),
        new Varer(17, "lille Protein Bar", 12, 15), new Varer(18,"stor protein bar", 22, 10), new Varer(19, "lille Müslibar", 10, 15),
        new Varer(20, "Stor Müslibar", 20, 10), new Varer(21,"lille Chips pose", 15, 12), new Varer(22, "Lille pringles", 16, 11) };

        public Automat()
        {

        }
    }
}
