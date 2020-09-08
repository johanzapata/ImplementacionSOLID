using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InplementacionSOLID.Nevera
{
    class Nevera : Electrodomestico.Electrodomestico, INevera
    {
        public Nevera()
        {
            this.Peso = 0;
        }

        public void ComprobarCarga()
        {
            
        }
    }
}
