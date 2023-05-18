using Poo_estructura.Entity;
using Poo_estructura.Servicios;
using System;

namespace Poo_estructura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello bitch!");

            AlumnoSer alumnoservi = new AlumnoSer();

           Alumno request = alumnoservi.Agregar();

            // var res = alumnoservi.Agregar();

            alumnoservi.Imprimir(request);
            Console.WriteLine(alumnoservi.ValidarPro(request.Promedio));
        }
    }
}
