using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InplementacionSOLID.Lavadoras;
using InplementacionSOLID.Televisor;
using InplementacionSOLID.InicioPrograma;

namespace InplementacionSOLID
{
    class Program 
    {
        static void Main(string[] args)
        {
            Inicio iniciar = new Inicio();
            iniciar.ComienzoPrograma();
        }
    }
}
