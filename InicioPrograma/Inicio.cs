using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using InplementacionSOLID.Lavadoras;
using InplementacionSOLID.Televisor;

namespace InplementacionSOLID.InicioPrograma
{
    class Inicio 
    {
        public void ComienzoPrograma()
        {
            string continuar = "si";
            while (continuar == "si")
            {
                try
                {
                    ComprobarSiEsTelevisorOLavadora();
                }
                catch
                {
                    Console.WriteLine("Se ingreso algo malo, intenta de nuevo");
                }
                Console.Write("Desea Continuar SI/NO ? ");
                continuar = Console.ReadLine().ToLower();
            }
        }

        public void FinalDePrograma(double precioBase, double peso)
        {
            //List<Lavadora> lsitaLavadora = new List<Lavadora>();
            List<Television> listaTelevisor = new List<Television>();
            //double precioFinalLavadora = 0;
            double precioFinalTelevisor = 0;

            //foreach (Lavadora lv in lsitaLavadora)
            //{
            //    lv.PrecioFinal(precioBase,peso);

            //    precioFinalLavadora += lv.PrecioBase;
            //}
            foreach (Television tv in listaTelevisor)
            {
                tv.PrecioFinal(precioBase, peso);

                precioFinalTelevisor += tv.PrecioBase;
            }

            //Console.WriteLine("El precio acumulado de la lavadora es {0}", precioFinalLavadora);
            Console.WriteLine("El precio acumulado del televisor es {0}", precioFinalTelevisor);
            Console.Read();
        }


        private void ComprobarSiEsTelevisorOLavadora()
        {
            Console.Write("Desea un televisor o una lavadora ");
            string tipo = Console.ReadLine().ToLower();

            ValidarSiEsTelevisorOLavadora(tipo);
        }
        private void ValidarSiEsTelevisorOLavadora(string tipo)
        {
            if (tipo == "televisor")
            {
                PedirParametros();
                
            }
        }
        private void PedirParametros()
        {
            Console.Write("Ingrese el color ");
            string color = Console.ReadLine();

            Console.Write("Ingrese el consumo ");
            char consumo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Ingrese el peso");
            double peso = Convert.ToDouble(Console.ReadLine());
            AsignarValoresATelevisor(color,consumo,peso);
        }
        private void AsignarValoresATelevisor(string color, char consumo, double peso)
        {
            List<Television> listaTelevisor = new List<Television>();
            Console.Write("ingrese la resolucion");
            double resolucion = Convert.ToDouble(Console.ReadLine());

            Console.Write("ingrese si tiene TDT SI/NO ");
            bool tdt = Console.ReadLine() == "si" ? true : false;

            Television televisor = new Television();
            televisor.Color = color;
            televisor.ConsumoEnergetico = consumo;
            televisor.Peso = peso;
            televisor.Resolucion = resolucion;
            televisor.TDT = tdt;

            listaTelevisor.Add(televisor);
        }
    }
}
