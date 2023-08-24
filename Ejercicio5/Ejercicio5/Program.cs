using System;
namespace Ejercicio5
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Serie[] series = new Serie[2];
            Videojuego[] videojuegos = new Videojuego[2];

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
                if (s != null && s.isEntregado())
                {
                    s.devolver();
                    entregadosS++;
                }
            }

            foreach (var v in videojuegos)
            {
                if (v != null && v.isEntregado())  
                {
                    v.devolver();
                    entregadosV++;
                }
            }
            Videojuego juegoConMasHoras = null;
            Serie serieConMasTemporadas = null;

            // Encontrar el videojuego con más horas
            foreach (var v in videojuegos)
            {
                if (v != null && (juegoConMasHoras == null || v.GetHorasEstimadas() > juegoConMasHoras.GetHorasEstimadas()))
                {
                    juegoConMasHoras = v;
                }
            }

            // Encontrar la serie con más temporadas
            foreach (var s in series)
            {
                if (s != null && (serieConMasTemporadas == null || s.GetNumeroTemporadas() > serieConMasTemporadas.GetNumeroTemporadas()))
                {
                    serieConMasTemporadas = s;
                }
            }

            // Mostrar los resultados
            if (juegoConMasHoras != null)
            {
                Console.WriteLine($"Videojuego con más horas estimadas:\n{juegoConMasHoras.ToString()}");
            }
            else
            {
                Console.WriteLine("No se encontró ningún videojuego.");
            }

            if (serieConMasTemporadas != null)
            {
                Console.WriteLine($"Serie con más temporadas:\n{serieConMasTemporadas.ToString()}");
            }
            else
            {
                Console.WriteLine("No se encontró ninguna serie.");
            }
            Console.WriteLine($"Total juegos entregados: {entregadosV}");
            Console.WriteLine($"Total series entregadas: {entregadosS}");
        }
    }
}