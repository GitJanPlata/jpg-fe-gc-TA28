using System;
using System.Linq;
using System.Text;

public class Password
{
    private int longitud;
    private string contraseña;

    public Password()
    {
        this.longitud = 8;
        this.contraseña = generarPassword();
    }

    public Password(int longitud)
    {
        this.longitud = longitud;
        this.contraseña = generarPassword();
    }

    public bool esFuerte()
    {
        int countMayusculas = contraseña.Count(Char.IsUpper);
        int countMinusculas = contraseña.Count(Char.IsLower);
        int countNumeros = contraseña.Count(Char.IsDigit);

        return countMayusculas > 2 && countMinusculas > 1 && countNumeros > 5;
    }

    private string generarPassword()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random random = new Random();
        return new string(Enumerable.Repeat(chars, longitud).Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public string GetContraseña() => this.contraseña;

    public int GetLongitud() => this.longitud;

    public void SetLongitud(int longitud)
    {
        this.longitud = longitud;
        this.contraseña = generarPassword(); 
    }
}

// Clase ejecutable
public class TestPassword
{
    public static void Main()
    {
        Console.WriteLine("Indica el número de contraseñas que quieres generar:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Indica la longitud para las contraseñas:");
        int longitud = int.Parse(Console.ReadLine());

        Password[] passwords = new Password[num];
        bool[] esFuerteArray = new bool[num];

        for (int i = 0; i < num; i++)
        {
            passwords[i] = new Password(longitud);
            esFuerteArray[i] = passwords[i].esFuerte();
        }

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine($"{passwords[i].GetContraseña()} {esFuerteArray[i]}");
        }
    }
}
