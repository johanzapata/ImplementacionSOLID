using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InplementacionSOLID.Electrodomestico
{
    interface IElectrodomestico
    {
        void ComprobarConsumoEnergetico(char consumoEnergetico);
        void ComprobarColor(string color);
        void PrecioFinal(double precioBase, double peso);
        void ComprobarElPrecioSegunElPeso();
    }
}
