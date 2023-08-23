using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    public class Aula
    {
        public int ID { get; set; }
        public int MaximoEstudiantes { get; set; }
        public Materia MateriaAula { get; set; }
        public Profesor Profesor { get; set; }
        public Estudiante[] Estudiantes { get; set; }

        public Aula(int id, int maxEstudiantes, Materia materia, Profesor profesor, Estudiante[] estudiantes)
        {
            ID = id;
            MaximoEstudiantes = maxEstudiantes;
            MateriaAula = materia;
            Profesor = profesor;
            Estudiantes = estudiantes;
        }

        public bool PuedeDarseClase()
        {
            if (Profesor == null || !Profesor.EstaDisponible() || Profesor.Materia != MateriaAula)
                return false;

            int contadorPresentes = 0;
            foreach (var estudiante in Estudiantes)
            {
                if (estudiante.EstaPresente())
                    contadorPresentes++;
            }

            return contadorPresentes > (MaximoEstudiantes / 2);
        }

        public void MostrarResultados()
        {
            if (!PuedeDarseClase())
            {
                Console.WriteLine("No se puede dar clase.");
                return;
            }

            int aprobadosMasculino = 0;
            int aprobadosFemenino = 0;

            foreach (var estudiante in Estudiantes)
            {
                if (estudiante.Calificacion >= 5)
                {
                    if (estudiante.Sexo == Sexo.Masculino)
                        aprobadosMasculino++;
                    else
                        aprobadosFemenino++;
                }
            }

            Console.WriteLine($"Alumnos aprobados: {aprobadosMasculino}");
            Console.WriteLine($"Alumnas aprobadas: {aprobadosFemenino}");
        }
    }
}
