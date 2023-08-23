using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Videojuego : Entregable
    {
        private string titulo;
        private int horasEstimadas = 10;
        private bool entregado = false;
        private string genero;
        private string compania;

        public Videojuego() { }

        public Videojuego(string titulo, int horasEstimadas)
        {
            this.titulo = titulo;
            this.horasEstimadas = horasEstimadas;
        }

        public Videojuego(string titulo, int horasEstimadas, string genero, string compania)
            : this(titulo, horasEstimadas)
        {
            this.genero = genero;
            this.compania = compania;
        }

        public string GetTitulo() => titulo;
        public int GetHorasEstimadas() => horasEstimadas;
        public string GetGenero() => genero;
        public string GetCompania() => compania;

        public void SetTitulo(string value) => titulo = value;
        public void SetHorasEstimadas(int value) => horasEstimadas = value;
        public void SetGenero(string value) => genero = value;
        public void SetCompania(string value) => compania = value;

        public override string ToString()
        {
            return $"Título: {titulo}, Horas Estimadas: {horasEstimadas}, Género: {genero}, Compañía: {compania}, Entregado: {entregado}";
        }

        public void entregar()
        {
            entregado = true;
        }

        public void devolver()
        {
            entregado = false;
        }

        public bool isEntregado()
        {
            return entregado;
        }

        public int compareTo(Object a)
        {
            Videojuego videojuego = (Videojuego)a;
            return horasEstimadas.CompareTo(videojuego.GetHorasEstimadas());
        }
    }
}
