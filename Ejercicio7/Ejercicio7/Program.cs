using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Raices ecuacion = new Raices(1, -5, 6); // Esto es x^2 - 5x + 6, cuyas raíces son x = 2 y x = 3.
            ecuacion.Calcular();
        }
    }
}


