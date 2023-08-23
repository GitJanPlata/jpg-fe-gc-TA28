using Ejercicio9;

class Program
{
    static void Main(string[] args)
    {
        Pelicula pelicula = new Pelicula("Matrix", 120, 16, "Lana Wachowski");
        Cine cine = new Cine(pelicula, 10.0);

        Random rand = new Random();
        for (int i = 0; i < 50; i++)
        {
            string nombre = $"Espectador_{i + 1}";
            int edad = rand.Next(5, 70);
            double dinero = rand.NextDouble() * 20;
            Espectador espectador = new Espectador(nombre, edad, dinero);

            cine.SentarEspectador(espectador);
        }
    }
}
