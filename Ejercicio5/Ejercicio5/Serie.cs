using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Serie : Entregable
    {
        private string titulo;
        private int numeroTemporadas = 3;
        private bool entregado = false;
        private string genero;
        private string creador;

        public Serie() { }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
        }

        public Serie(string titulo, int numeroTemporadas, string genero, string creador)
            : this(titulo, creador)
        {
            this.numeroTemporadas = numeroTemporadas;
            this.genero = genero;
        }

        public string GetTitulo() => titulo;
        public int GetNumeroTemporadas() => numeroTemporadas;
        public string GetGenero() => genero;
        public string GetCreador() => creador;

        public void SetTitulo(string value) => titulo = value;
        public void SetNumeroTemporadas(int value) => numeroTemporadas = value;
        public void SetGenero(string value) => genero = value;
        public void SetCreador(string value) => creador = value;

        public override string ToString()
        {
            return $"Título: {titulo}, Temporadas: {numeroTemporadas}, Género: {genero}, Creador: {creador}, Entregado: {entregado}";
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
            Serie serie = (Serie)a;
            return numeroTemporadas.CompareTo(serie.GetNumeroTemporadas());
        }

    }
}
