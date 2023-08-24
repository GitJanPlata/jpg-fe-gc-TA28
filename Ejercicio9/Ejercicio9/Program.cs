using Ejercicio9;

class Program
{
 
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Pelicula pelicula = new Pelicula("El gran show", 120, 12, "P.T. Barnum");
            Cine cine = new Cine(pelicula, 10);

            for (int i = 0; i < 50; i++)
            {
                Espectador espectador = GenerarEspectador();
                cine.IntentarSentar(espectador);
            }
        }

        static Espectador GenerarEspectador()
        {
            string nombre = $"Espectador {rnd.Next(1, 101)}";
            int edad = rnd.Next(5, 80);
            double dinero = rnd.Next(5, 20);

            return new Espectador(nombre, edad, dinero);
        }
}
