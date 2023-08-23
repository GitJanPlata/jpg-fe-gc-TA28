using System;

public class Electrodomestico
{
    // Constantes
    protected const double PRECIO_BASE = 100;
    protected const char CONSUMO_ENERGETICO_DEFAULT = 'F';
    protected const double PESO_DEFAULT = 5;
    protected const string COLOR_DEFAULT = "blanco";

    // Atributos
    protected double precioBase;
    protected string color;
    protected char consumoEnergetico;
    protected double peso;

    public Electrodomestico()
    {
        this.precioBase = PRECIO_BASE;
        this.color = COLOR_DEFAULT;
        this.consumoEnergetico = CONSUMO_ENERGETICO_DEFAULT;
        this.peso = PESO_DEFAULT;
    }

    public Electrodomestico(double precio, double peso)
    {
        this.precioBase = precio;
        this.peso = peso;
        this.color = COLOR_DEFAULT;
        this.consumoEnergetico = CONSUMO_ENERGETICO_DEFAULT;
    }

    public Electrodomestico(double precio, double peso, string color, char consumoEnergetico)
    {
        this.precioBase = precio;
        this.peso = peso;
        this.color = comprobarColor(color);
        this.consumoEnergetico = comprobarConsumoEnergetico(consumoEnergetico);
    }

    private char comprobarConsumoEnergetico(char letra)
    {
        if ("ABCDEF".Contains(Char.ToUpper(letra)))
            return Char.ToUpper(letra);
        else
            return CONSUMO_ENERGETICO_DEFAULT;
    }

    private string comprobarColor(string color)
    {
        string[] colores = { "blanco", "negro", "rojo", "azul", "gris" };
        if (colores.Contains(color.ToLower()))
            return color.ToLower();
        else
            return COLOR_DEFAULT;
    }

    public virtual double precioFinal()
    {
        double adicion = 0;
        switch (Char.ToUpper(consumoEnergetico))
        {
            case 'A':
                adicion += 100;
                break;
            case 'B':
                adicion += 80;
                break;
            case 'C':
                adicion += 60;
                break;
            case 'D':
                adicion += 50;
                break;
            case 'E':
                adicion += 30;
                break;
            case 'F':
                adicion += 10;
                break;
        }

        if (peso < 20) adicion += 10;
        else if (peso < 50) adicion += 50;
        else if (peso < 80) adicion += 80;
        else adicion += 100;

        return precioBase + adicion;
    }

    // Métodos Get
    public double GetPrecioBase() => this.precioBase;
    public string GetColor() => this.color;
    public char GetConsumoEnergetico() => this.consumoEnergetico;
    public double GetPeso() => this.peso;
}

public class Lavadora : Electrodomestico
{
    const int CARGA_DEFAULT = 5;

    private int carga;

    public Lavadora() : base()
    {
        this.carga = CARGA_DEFAULT;
    }

    public Lavadora(double precio, double peso) : base(precio, peso)
    {
        this.carga = CARGA_DEFAULT;
    }

    public Lavadora(double precio, double peso, string color, char consumoEnergetico, int carga)
        : base(precio, peso, color, consumoEnergetico)
    {
        this.carga = carga;
    }

    public override double precioFinal()
    {
        double precio = base.precioFinal();
        if (carga > 30) precio += 50;
        return precio;
    }

    public int GetCarga() => this.carga;
}

public class Television : Electrodomestico
{
    const int RESOLUCION_DEFAULT = 20;

    private int resolucion;
    private bool sintonizadorTDT;

    public Television() : base()
    {
        this.resolucion = RESOLUCION_DEFAULT;
        this.sintonizadorTDT = false;
    }

    public Television(double precio, double peso) : base(precio, peso)
    {
        this.resolucion = RESOLUCION_DEFAULT;
        this.sintonizadorTDT = false;
    }

    public Television(double precio, double peso, string color, char consumoEnergetico, int resolucion, bool sintonizador)
        : base(precio, peso, color, consumoEnergetico)
    {
        this.resolucion = resolucion;
        this.sintonizadorTDT = sintonizador;
    }

    public override double precioFinal()
    {
        double precio = base.precioFinal();
        if (resolucion > 40) precio *= 1.3;
        if (sintonizadorTDT) precio += 50;
        return precio;
    }

    public int GetResolucion() => this.resolucion;
    public bool GetSintonizadorTDT() => this.sintonizadorTDT;
}

public class Program
{
    static void Main()
    {
        Electrodomestico[] electrodomesticos = new Electrodomestico[10];

        // Ejemplo: Rellenamos el array con algunos electrodomésticos
        electrodomesticos[0] = new Electrodomestico(200, 60, "rojo", 'C');
        electrodomesticos[1] = new Lavadora(300, 50, "blanco", 'A', 40);
        electrodomesticos[2] = new Television(400, 70, "negro", 'B', 45, true);

        double precioTotalElectrodomesticos = 0;
        double precioTotalLavadoras = 0;
        double precioTotalTelevisores = 0;

        foreach (var e in electrodomesticos)
        {
            if (e != null)
            {
                if (e is Lavadora)
                {
                    precioTotalLavadoras += e.precioFinal();
                }
                else if (e is Television)
                {
                    precioTotalTelevisores += e.precioFinal();
                }

                precioTotalElectrodomesticos += e.precioFinal();
            }
        }

        Console.WriteLine($"Total Electrodomésticos: {precioTotalElectrodomesticos}€");
        Console.WriteLine($"Total Lavadoras: {precioTotalLavadoras}€");
        Console.WriteLine($"Total Televisores: {precioTotalTelevisores}€");
    }
}
