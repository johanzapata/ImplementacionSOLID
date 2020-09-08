using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InplementacionSOLID.InicioPrograma
{
    public interface Iinicio
    {
        void ComienzoPrograma();
        (string tipo, string color, char consumo, double peso) ComprobarSiEsTelevisorOLavadora();
        void ValidarSiEsTelevisorOLavadora(string tipo, string color, char consumo, double peso);
        void FinalDePrograma(double precioBase, double peso);
    }
}
