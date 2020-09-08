using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InplementacionSOLID.Electrodomestico;

namespace InplementacionSOLID.Televisor
{
    class Television : Electrodomestico.Electrodomestico
    {
        private double resolucion;
        private bool tdt;
        public double Resolucion {get { return this.resolucion; } set { this.resolucion = value; } }
        public bool TDT { get { return this.tdt; } set { this.tdt = value; } }

        public Television() { }

        public Television(double precioBase, double peso) : base(precioBase, peso) { }

        public Television(double precioBase, string color, char consumo, double peso, double resolucion, bool tdt) : base(precioBase, color, consumo, peso)
        {
            this.resolucion = resolucion;
            this.tdt = tdt;
        }
        public override void PrecioFinal(double precioBase, double peso)
        {
            base.PrecioFinal(precioBase,peso);
            if (this.Resolucion >= 40)
            {
                this.PrecioBase += (this.PrecioBase * 0.3);

            }
            if (this.TDT == true)
            {
                this.PrecioBase += 50;
            }
        }
    }
}
