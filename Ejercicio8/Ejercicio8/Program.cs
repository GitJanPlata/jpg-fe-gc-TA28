using System;
namespace Ejercicio8
{
    public enum Sexo { Masculino, Femenino };
    public enum Materia { Matematicas, Filosofia, Fisica };

    class Program
    {
        static void Main(string[] args)
        {
            Profesor profesor = new Profesor("Juan", 35, Sexo.Masculino, Materia.Matematicas);
            Estudiante[] estudiantes = {
            new Estudiante("Ana", 18, Sexo.Femenino, 6.5),
            new Estudiante("Pedro", 19, Sexo.Masculino, 4.3),
        };

            Aula aula = new Aula(1, 30, Materia.Matematicas, profesor, estudiantes);
            aula.MostrarResultados();
        }
    }
}