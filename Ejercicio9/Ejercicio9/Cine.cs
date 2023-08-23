using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    using System;

    public class Cine
    {
        public Pelicula Pelicula { get; set; }
        public double PrecioEntrada { get; set; }
        public Asiento[,] Asientos { get; private set; }

        public Cine(Pelicula pelicula, double precioEntrada)
        {
            Pelicula = pelicula;
            PrecioEntrada = precioEntrada;
            Asientos = new Asiento[8, 9];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Asientos[i, j] = new Asiento(8 - i, (char)('A' + j));
                }
            }
        }

        public bool SentarEspectador(Espectador espectador)
        {
            if (espectador.Dinero < PrecioEntrada || espectador.Edad < Pelicula.EdadMinima)
            {
                return false;
            }

            Random rand = new Random();
            while (true)
            {
                int fila = rand.Next(0, 8);
                int columna = rand.Next(0, 9);

                if (!Asientos[fila, columna].Ocupado)
                {
                    Asientos[fila, columna].Ocupado = true;
                    espectador.Dinero -= PrecioEntrada;
                    return true;
                }
            }
        }
    }

}
