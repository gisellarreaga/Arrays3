using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays3
{
    class Program
    {
        //Ejercicio con arrreglos, if y for.
        // Pablo:    Quimica 10 y Fisica 8
        // Luis:     Quimica 9 y Fisica 9
        // Rodolfo:  Quimica 8 y Fisica 10
        // Ana:      Quimica 10 y Fisica 8
        // Gabriela: Quimica 9 y Fisica 7
        private float[] quimica;
        private float[] fisica;
        private float[] promFinal;
        private string[] alumnos;
        
        public void Calificaciones()
        {
            alumnos = new string[5] { "Pablo", "Luis", "Rodolfo", "Ana", "Gabriela" };
            quimica = new float[5];
            fisica = new float[5];

            Console.WriteLine("     CALIFICACIONES DE LA MATERIA DE QUIMICA: \n");
            for (int x = 0; x < alumnos.Length; x++)
            {
                Console.WriteLine("Ingresar la calificacion de " + alumnos[x] + ": ");
                String gradeCaptureQuimica = Console.ReadLine();
                quimica[x] = float.Parse(gradeCaptureQuimica);
            }
            Console.Clear();

            Console.WriteLine("     CALIFICACIONES DE LA MATERIA DE FISICA: \n");
            for (int x = 0; x < alumnos.Length; x++)
            {
                Console.WriteLine("Ingresar la calificacion de " + alumnos[x] + ": ");
                String gradeCaptureFisica = Console.ReadLine();
                fisica[x] = float.Parse(gradeCaptureFisica);
            }

            Console.Clear();
        }
        public void calcularPromedio()
        {
            promFinal = new float[5];
            float maxGrade = 0;
            float totalQuimica = 0;
            float totalFisica = 0;

            Console.WriteLine("     CALIFICACIONES DE LOS ALUMNOS: \n");
            for (int i = 0; i < alumnos.Length; i++)
            {
                promFinal[i] = (quimica[i] + fisica[i]) / 2;
                if (promFinal[i] >= maxGrade)
                {
                    maxGrade = promFinal[i];
                }

                Console.WriteLine("Alumno: " + alumnos[i] + "  |  Quimica: " + quimica[i] + "  |  Fisica: " + fisica[i] + "  |  Su promedio General es: " + promFinal[i]);

            }


            for (int i = 0; i < quimica.Length; i++)
            {
                totalQuimica = totalQuimica + quimica[i];
            }

            for (int i = 0; i < fisica.Length; i++)
            {
                totalFisica = totalFisica + fisica[i];
            }
            Console.WriteLine("\n");
            Console.WriteLine("     PROMEDIO GENERAL DE CADA MATERIA: \n");
            Console.WriteLine("Promedio de la materia de Quimica: " + totalQuimica / 5 + "\nPromedio de la materia de Fisica: " + totalFisica / 5);

            Console.WriteLine("\n");
            Console.WriteLine("     LA MATERIA CON EL MAYOR PROMEDIO ES: \n");

            if (totalQuimica > totalFisica)
            {
                Console.WriteLine("Materia: Quimica" );
            } else
            {
                Console.WriteLine("Materia: Fisica");
            }

            
        }


        static void Main(string[] args)
        {
            Program grades = new Program();
            grades.Calificaciones();
            grades.calcularPromedio();
            Console.ReadKey();
        }
    }
}
