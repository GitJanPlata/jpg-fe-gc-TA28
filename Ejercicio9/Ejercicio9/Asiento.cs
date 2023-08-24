using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    public class Asiento
    {
        public string Identificador { get; private set; }
        public bool Ocupado { get; set; }

        public Asiento(string identificador)
        {
            Identificador = identificador;
            Ocupado = false;
        }
    }

}
