using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Varer
    {
        private string vareNavn;
        private int vareID, varePris, vareAntal;

        public string VareNavn { set { vareNavn = value; } get { return vareNavn; } }
        public int VareID { set { vareID = value; } get { return vareID; } }
        public int VarePris { set { varePris = value; } get { return varePris; } }
        public int VareAntal { set { vareAntal = value; } get { return vareAntal; } }


        public Varer(int vareId, string varenavn, int varepris, int vareantal)
        {
            this.vareID = vareId;
            this.vareNavn = varenavn;
            this.varePris = varepris;
            this.vareAntal = vareantal;
        }
    }
}
