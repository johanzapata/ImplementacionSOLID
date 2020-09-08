using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InplementacionSOLID.Electrodomestico;

namespace InplementacionSOLID.Lavadoras
{
    class Lavadora :  Electrodomestico.Electrodomestico,  ILavadora 
    {
        private int carga;
        public int Carga { get { return this.carga; } set { this.carga = value; } }
        public Lavadora()
        {
            carga = 5;
        }

        public Lavadora(int carga)
        {
            this.Carga = carga;
        }

        public Lavadora(double precio, double peso) 
        {

        }
        public Lavadora(double precio, string color, char consumo, double peso, int carga)
        {
            this.Carga = carga;
        }
        public override void PrecioFinal(double precioBase, double peso)
        {
            if (this.Carga <= 30)
            {
                base.PrecioBase =+ 50;
            }
        }
    }
}
