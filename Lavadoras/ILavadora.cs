using InplementacionSOLID.Electrodomestico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InplementacionSOLID.Lavadoras
{
    interface ILavadora
    {
        void PrecioFinal(double precioBase, double peso);
    }
}