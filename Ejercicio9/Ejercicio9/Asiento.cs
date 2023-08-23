using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    public class Asiento
    {
        public int Fila { get; set; }
        public char Columna { get; set; }
        public bool Ocupado { get; set; }

        public Asiento(int fila, char columna)
        {
            Fila = fila;
            Columna = columna;
            Ocupado = false;
        }

        public override string ToString()
        {
            return $"{Fila}{Columna}";
        }
    }

}
