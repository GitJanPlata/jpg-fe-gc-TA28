using System;
namespace Ejercicio5
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Serie[] series = new Serie[5];
            Videojuego[] videojuegos = new Videojuego[5];

            series[0] = new Serie("Stranger Things", 3, "Misterio", "Duffer Brothers");
            series[1] = new Serie("The Witcher", 2, "Fantasía", "Lauren Schmidt Hissrich");

            videojuegos[0] = new Videojuego("The Last of Us", 20, "Acción", "Naughty Dog");
            videojuegos[1] = new Videojuego("Minecraft", 100, "Sandbox", "Mojang");

            series[0].entregar();
            videojuegos[0].entregar();

            int entregadosS = 0;
            int entregadosV = 0;
            foreach (var s in series)
            {
                if (s.isEntregado())
                {
                    s.devolver();
                    entregadosS++;
                }
            }

            foreach (var v in videojuegos)
            {
                if (v.isEntregado())
                {
                    v.devolver();
                    entregadosV++;
                }
            }

            Console.WriteLine($"Total juegos entregados: {entregadosV}");
            Console.WriteLine($"Total series entregadas: {entregadosS}");
        }
    }
}