using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class Raices
    {
        private double a;
        private double b;
        private double c;

        public Raices(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetDiscriminante()
        {
            return (b * b) - 4 * a * c;
        }

        public bool TieneRaices()
        {
            return GetDiscriminante() >= 0;
        }

        public bool TieneRaiz()
        {
            return GetDiscriminante() == 0;
        }

        public void ObtenerRaices()
        {
            if (TieneRaices())
            {
                double discriminante = Math.Sqrt(GetDiscriminante());
                double raiz1 = (-b + discriminante) / (2 * a);
                double raiz2 = (-b - discriminante) / (2 * a);
                Console.WriteLine($"Las raíces son: {raiz1} y {raiz2}");
            }
            else
            {
                Console.WriteLine("No tiene raíces reales.");
            }
        }

        public void ObtenerRaiz()
        {
            if (TieneRaiz())
            {
                double raiz = -b / (2 * a);
                Console.WriteLine($"La única raíz es: {raiz}");
            }
            else
            {
                Console.WriteLine("No tiene una única raíz real.");
            }
        }

        public void Calcular()
        {
            if (TieneRaiz())
            {
                ObtenerRaiz();
            }
            else if (TieneRaices())
            {
                ObtenerRaices();
            }
            else
            {
                Console.WriteLine("No tiene solución en los números reales.");
            }
        }
    }
}
