using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    public class Espectador
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Dinero { get; set; }

        public Espectador(string nombre, int edad, double dinero)
        {
            Nombre = nombre;
            Edad = edad;
            Dinero = dinero;
        }
    }

}
