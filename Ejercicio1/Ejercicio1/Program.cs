using System;

public class Cuenta
{
    private string titular;
    private double cantidad;

    public Cuenta(string titular, double cantidad)
    {
        this.titular = titular;
        if (cantidad < 0)
        {
            this.cantidad = 0;
        }
        else
        {
            this.cantidad = cantidad;
        }
    }

    public Cuenta(string titular) : this(titular, 0) { } // Llamada al otro constructor


    public string Titular
    {
        get
        {
            return titular;
        }
        set
        {
            titular = value;
        }
    }

    public double Cantidad
    {
        get
        {
            return cantidad;
        }
        set
        {
            if (value < 0)
            {
                cantidad = 0;
            }
            else
            {
                cantidad = value;
            }
        }
    }

    public override string ToString()
    {
        return $"Titular: {titular}, Cantidad: {cantidad}";
    }

    // Método para ingresar cantidad
    public void Ingresar(double cantidad)
    {
        if (cantidad > 0)
        {
            this.cantidad += cantidad;
        }
    }

    // Método para retirar cantidad
    public void Retirar(double cantidad)
    {
        if (this.cantidad - cantidad < 0)
        {
            this.cantidad = 0;
        }
        else
        {
            this.cantidad -= cantidad;
        }
    }

    public static void Main(string[] args)
    {
        Cuenta cuenta1 = new Cuenta("Juan");
        Cuenta cuenta2 = new Cuenta("Marta", 500.5);

        cuenta1.Ingresar(300.5);
        cuenta2.Retirar(100);

        Console.WriteLine(cuenta1);
        Console.WriteLine(cuenta2);
    }
}
