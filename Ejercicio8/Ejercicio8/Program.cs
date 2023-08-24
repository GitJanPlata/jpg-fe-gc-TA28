using System;
namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor profesor = new Profesor("Juan", 35, Sexo.Masculino, Materia.Matematicas);

            Estudiante[] estudiantes = {
            new Estudiante("Ana", 18, Sexo.Femenino, 6.5),
            new Estudiante("Pedro", 19, Sexo.Masculino, 4.3),
            new Estudiante("Luis", 20, Sexo.Masculino, 7.8),
            new Estudiante("Maria", 18, Sexo.Femenino, 9.1),
            new Estudiante("Carla", 21, Sexo.Femenino, 8.4),
            new Estudiante("David", 22, Sexo.Masculino, 5.5),
            new Estudiante("Lorena", 20, Sexo.Femenino, 6.6),
            new Estudiante("Jorge", 23, Sexo.Masculino, 4.4),
            new Estudiante("Cristina", 19, Sexo.Femenino, 5.0),
            new Estudiante("Roberto", 24, Sexo.Masculino, 7.2)
        };

            Aula aula = new Aula(1, 10, Materia.Matematicas, profesor, estudiantes);
            aula.MostrarResultados();
        }
    }
}