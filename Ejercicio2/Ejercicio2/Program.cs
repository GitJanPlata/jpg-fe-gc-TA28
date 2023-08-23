using System;

public class Persona
{
    // Atributos y constantes
    private const char SEXO_DEFAULT = 'H';
    private string nombre;
    private int edad;
    private string DNI;
    private char sexo;
    private double peso;
    private double altura;

    // Constructores
    public Persona()
    {
        this.nombre = "";
        this.edad = 0;
        this.DNI = generaDNI();
        this.sexo = SEXO_DEFAULT;
        this.peso = 0;
        this.altura = 0;
    }

    public Persona(string nombre, int edad, char sexo)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.DNI = generaDNI();
        this.sexo = comprobarSexo(sexo);
        this.peso = 0;
        this.altura = 0;
    }

    public Persona(string nombre, int edad, char sexo, double peso, double altura)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.DNI = generaDNI();
        this.sexo = comprobarSexo(sexo);
        this.peso = peso;
        this.altura = altura;
    }

    // Métodos
    public int calcularIMC()
    {
        double imc = this.peso / Math.Pow(this.altura, 2);
        if (imc < 20) return -1;
        if (imc <= 25) return 0;
        return 1;
    }

    public bool esMayorDeEdad()
    {
        return this.edad >= 18;
    }

    private char comprobarSexo(char sexo)
    {
        if (sexo == 'H' || sexo == 'M') return sexo;
        return SEXO_DEFAULT;
    }

    public override string ToString()
    {
        return $"Nombre: {nombre}, Edad: {edad}, DNI: {DNI}, Sexo: {sexo}, Peso: {peso}, Altura: {altura}";
    }

    private string generaDNI()
    {
        const string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
        Random rnd = new Random();
        int numero = rnd.Next(10000000, 100000000);
        char letra = letras[numero % 23];
        return $"{numero}{letra}";
    }

    public void SetNombre(string nombre) => this.nombre = nombre;

    public void SetEdad(int edad) => this.edad = edad;

    public void SetSexo(char sexo) => this.sexo = comprobarSexo(sexo);

    public void SetPeso(double peso) => this.peso = peso;

    public void SetAltura(double altura) => this.altura = altura;
}

public class TestPersona
{
    public static void Main()
    {
        Console.WriteLine("Introduce tu nombre:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Introduce tu edad:");
        int edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce tu sexo (H/M):");
        char sexo = char.Parse(Console.ReadLine().ToUpper());

        Console.WriteLine("Introduce tu peso:");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Introduce tu altura:");
        double altura = double.Parse(Console.ReadLine());

        Persona persona1 = new Persona(nombre, edad, sexo, peso, altura);
        Persona persona2 = new Persona(nombre, edad, sexo);
        Persona persona3 = new Persona();

        persona3.SetNombre("David");
        persona3.SetEdad(30);
        persona3.SetSexo('H');
        persona3.SetPeso(70);
        persona3.SetAltura(1.75);

        mostrarInformacion(persona1);
        mostrarInformacion(persona2);
        mostrarInformacion(persona3);
    }

    public static void mostrarInformacion(Persona persona)
    {
        Console.WriteLine(persona);

        switch (persona.calcularIMC())
        {
            case -1:
                Console.WriteLine("Está por debajo de su peso ideal.");
                break;
            case 0:
                Console.WriteLine("Está en su peso ideal.");
                break;
            case 1:
                Console.WriteLine("Tiene sobrepeso.");
                break;
        }

        if (persona.esMayorDeEdad())
        {
            Console.WriteLine("Es mayor de edad.");
        }
        else
        {
            Console.WriteLine("No es mayor de edad.");
        }

        Console.WriteLine("------------------------------");
    }
}
