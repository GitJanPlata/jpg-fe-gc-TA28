using Ejercicio6;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("978-3-16-148410-0", "La sombra del viento", "Carlos Ruiz Zafón", 540);
            Libro libro2 = new Libro("978-1-63-215456-4", "Cien años de soledad", "Gabriel García Márquez", 431);

            Console.WriteLine(libro1);
            Console.WriteLine(libro2);

            if (libro1.GetNumeroPaginas() > libro2.GetNumeroPaginas())
            {
                Console.WriteLine($"El libro \"{libro1.GetTitulo()}\" tiene más páginas.");
            }
            else if (libro1.GetNumeroPaginas() < libro2.GetNumeroPaginas())
            {
                Console.WriteLine($"El libro \"{libro2.GetTitulo()}\" tiene más páginas.");
            }
            else
            {
                Console.WriteLine("Ambos libros tienen el mismo número de páginas.");
            }
        }
    }
}
