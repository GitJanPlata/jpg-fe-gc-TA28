using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{

    public class Cine
    {
        private const int FILAS = 8;
        private const int COLUMNAS = 9;
        private Asiento[,] asientos = new Asiento[FILAS, COLUMNAS];

        public Pelicula PeliculaActual { get; set; }
        public double PrecioEntrada { get; private set; }

        public Cine(Pelicula pelicula, double precioEntrada)
        {
            PeliculaActual = pelicula;
            PrecioEntrada = precioEntrada;

            InicializarAsientos();
        }

        private void InicializarAsientos()
        {
            for (int fila = 0; fila < FILAS; fila++)
            {
                for (int columna = 0; columna < COLUMNAS; columna++)
                {
                    char letraColumna = (char)('A' + columna);
                    asientos[fila, columna] = new Asiento($"{FILAS - fila} {letraColumna}");
                }
            }
        }

        public bool IntentarSentar(Espectador espectador)
        {
            // Revisar si cumple con las condiciones para entrar al cine
            if (espectador.Edad < PeliculaActual.EdadMinima || espectador.Dinero < PrecioEntrada)
                return false;

            // Buscar asiento libre
            for (int fila = 0; fila < FILAS; fila++)
            {
                for (int columna = 0; columna < COLUMNAS; columna++)
                {
                    if (!asientos[fila, columna].Ocupado)
                    {
                        asientos[fila, columna].Ocupado = true;
                        Console.WriteLine($"El {espectador.Nombre} se ha sentado en el asiento {asientos[fila, columna].Identificador}");
                        espectador.Pagar(PrecioEntrada);
                        return true;
                    }
                }
            }
            return false;
        }
    }

}
