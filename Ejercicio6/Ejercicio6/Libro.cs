using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    public class Libro
    {
        private string ISBN;
        private string titulo;
        private string autor;
        private int numeroPaginas;

        public Libro(string ISBN, string titulo, string autor, int numeroPaginas)
        {
            this.ISBN = ISBN;
            this.titulo = titulo;
            this.autor = autor;
            this.numeroPaginas = numeroPaginas;
        }

        public string GetISBN() => ISBN;
        public string GetTitulo() => titulo;
        public string GetAutor() => autor;
        public int GetNumeroPaginas() => numeroPaginas;

        public void SetISBN(string value) => ISBN = value;
        public void SetTitulo(string value) => titulo = value;
        public void SetAutor(string value) => autor = value;
        public void SetNumeroPaginas(int value) => numeroPaginas = value;

        public override string ToString()
        {
            return $"El libro con ISBN {ISBN} creado por el autor {autor} tiene {numeroPaginas} páginas";
        }
    }

}
