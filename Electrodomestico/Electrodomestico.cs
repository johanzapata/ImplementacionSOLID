using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InplementacionSOLID.Electrodomestico
{
    class Electrodomestico : IElectrodomestico
    {
        //ATRIBUTOS DE ELECTRODOMESTICOS
        private double precioBase;
        private string color;
        private char consumoEnergetico;
        private double peso;
        private char consumo;

        //private double precioFinal;

        public double PrecioBase { get { return this.precioBase; } set { this.precioBase = value; } }
        public string Color { get { return this.color; } set { this.color = value.ToLower(); } }
        public double Peso { get { return this.peso; } set { this.peso = value; } }
        public char ConsumoEnergetico 
        {
            get { return this.consumoEnergetico; }
            set { this.consumoEnergetico = Convert.ToChar(value.ToString().ToUpper()); }
        }
        public Electrodomestico(double precioBase, double peso)
        {
            this.PrecioBase = precioBase;
            this.Peso = peso;
        }        
        public Electrodomestico()
        {
            //SE LE ASIGNA UN VALOR POR FAUL.
            precioBase = 100;
            color = "blanco";
            consumoEnergetico = 'f';
            peso = 5;
        }
        public Electrodomestico(double precioBase, string color, char consumo, double peso)
        {
            this.precioBase = precioBase;
            this.color = color;
            this.consumo = consumo;
            this.peso = peso;
        }
        public void ComprobarColor(string color)
        {
            string[] colores = { "blanco", "negro", "rojo", "azul", "gris" };
            bool encontro = false;
            for (int i = 0; i < colores.Length; i++)
            {
                if (color == colores[i])
                {
                    encontro = true;
                    break;
                }
            }
            if (!encontro)
            {
                this.Color = "blanco";
            }
        }
        public void ComprobarConsumoEnergetico(char letra)
        {
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F' };
            bool encontro = false;
            for (int i = 0; i < letras.Length; i++)
            {
                if (letra == letras[i])
                {
                    encontro = true;
                    break;
                }
            }
            if (!encontro)
            {
                this.ConsumoEnergetico = 'F';
            }
        }
        public virtual void PrecioFinal(double precioBase, double peso)
        {
            switch (this.ConsumoEnergetico)
            {
                case 'A':
                    this.PrecioBase = 100;
                    break;
                case 'B':
                    this.PrecioBase = 80;
                    break;
                case 'C':
                    this.PrecioBase = 60;
                    break;
                case 'D':
                    this.PrecioBase = 50;
                    break;
                case 'E':
                    this.PrecioBase = 30;
                    break;
                case 'F':
                    this.PrecioBase = 10;
                    break;
            }
           
        }
        public void ComprobarElPrecioSegunElPeso()
        {
            if (this.Peso > 0 && this.Peso <= 19)
            {
                this.PrecioBase += 10;
            }
            else if (this.Peso >= 20 && this.Peso <= 49)
            {
                this.PrecioBase += 50;
            }
            else if (this.Peso <= 50 && this.Peso <= 79)
            {
                this.PrecioBase += 80;
            }
            else
            {
                this.PrecioBase += 100;
            }
        }
    }
}
