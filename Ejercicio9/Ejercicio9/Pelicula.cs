using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public int Duracion { get; set; } // en minutos
        public int EdadMinima { get; set; }
        public string Director { get; set; }

        public Pelicula(string titulo, int duracion, int edadMinima, string director)
        {
            Titulo = titulo;
            Duracion = duracion;
            EdadMinima = edadMinima;
            Director = director;
        }
    }

}
