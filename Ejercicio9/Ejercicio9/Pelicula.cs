using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    public class Pelicula
    {
        public string Titulo { get; private set; }
        public int Duracion { get; private set; } 
        public int EdadMinima { get; private set; }
        public string Director { get; private set; }

        public Pelicula(string titulo, int duracion, int edadMinima, string director)
        {
            Titulo = titulo;
            Duracion = duracion;
            EdadMinima = edadMinima;
            Director = director;
        }
    }

}
