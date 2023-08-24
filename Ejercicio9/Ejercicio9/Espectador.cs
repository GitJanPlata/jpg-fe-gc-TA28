using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    public class Espectador
    {
        public string Nombre { get; private set; }
        public int Edad { get; private set; }
        public double Dinero { get; private set; }

        public Espectador(string nombre, int edad, double dinero)
        {
            Nombre = nombre;
            Edad = edad;
            Dinero = dinero;
        }
        public bool Pagar(double cantidad)
        {
            if (Dinero >= cantidad)
            {
                Dinero -= cantidad;
                return true;
            }
            return false;
        }
    }


}
