using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InplementacionSOLID.Electrodomestico;

namespace InplementacionSOLID.Electrodomestico
{
    class MetodosElectrodomestico : Electrodomestico, IElectrodomestico
    {
        public MetodosElectrodomestico()
        {
        }

        

        public MetodosElectrodomestico(double precioBase, string color, char consumoEnergetico, double peso)
        {
            this.PrecioBase = precioBase;
            this.Color = color;
            this.ConsumoEnergetico = consumoEnergetico;
            this.Peso = peso;
        }
    }    
}
