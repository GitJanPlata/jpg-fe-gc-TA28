using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Sexo Sexo { get; set; }

        public Persona(string nombre, int edad, Sexo sexo)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
        }
    }

    public class Estudiante : Persona
    {
        public double Calificacion { get; set; }

        public Estudiante(string nombre, int edad, Sexo sexo, double calificacion)
            : base(nombre, edad, sexo)
        {
            Calificacion = calificacion;
        }

        public bool EstaPresente()
        {
            return new Random().NextDouble() > 0.5;
        }
    }

    public class Profesor : Persona
    {
        public Materia Materia { get; set; }

        public Profesor(string nombre, int edad, Sexo sexo, Materia materia)
            : base(nombre, edad, sexo)
        {
            Materia = materia;
        }

        public bool EstaDisponible()
        {
            return new Random().NextDouble() > 0.2;
        }
    }

}
