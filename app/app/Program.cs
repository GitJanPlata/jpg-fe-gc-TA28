public class Libro
{
    private string autor;
    private string titulo;
    private string ubicacion;

    public string GetAutor()
    {
        return autor;
    }

    public void SetAutor(string autor)
    {
        this.autor = autor;
    }

    public string GetTitulo()
    {
        return titulo;
    }

    public void SetTitulo(string titulo)
    {
        this.titulo = titulo;
    }

    public string GetUbicacion()
    {
        return ubicacion;
    }

    public void SetUbicacion(string ubicacion)
    {
        this.ubicacion = ubicacion;
    }

    public static void Main(string[] args)
    {
        Libro libro1 = new Libro();

        libro1.SetAutor("Gabriel Garcia Marquez");
        libro1.SetTitulo("Cien años de soledad");
        libro1.SetUbicacion("Estante 3, Sección B");

        Console.WriteLine($"Autor: {libro1.GetAutor()}");
        Console.WriteLine($"Título: {libro1.GetTitulo()}");
        Console.WriteLine($"Ubicación: {libro1.GetUbicacion()}");

        Console.ReadKey();
    }
}