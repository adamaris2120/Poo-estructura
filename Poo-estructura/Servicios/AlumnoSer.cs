using Poo_estructura.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_estructura.Servicios
{
    public class AlumnoSer
    {
        //   -response-        -request-
        public Alumno Agregar()
        {
            try
            {
                Alumno alumno2 = new Alumno()
                {
                    Id = 1,
                    Name = "Aris",
                    Apellido = "Gomez",
                    FechaIngreso = DateTime.Now,
                    Grado = 3,
                    Promedio= 9.5

                };



                return alumno2;
            }

            catch(Exception ex)
            {


                throw new Exception("sucedio  un error" + ex.Message);
            }
           
        }

        public void Imprimir(Alumno request)
        {
            try
            {
                Console.WriteLine("EL nombre es:"+request.Name);

                Console.WriteLine("El apellido es:"+request.Apellido);
                Console.WriteLine("La fecah de ingres es:"+request.FechaIngreso);
                Console.WriteLine("El grado es:"+request.Grado);
                Console.WriteLine("EL ID es:"+request.Id);

            }
            catch(Exception ex)
            {

                throw new Exception("sucedio un error" + ex.Message);
            }
        }
        #region ---validar aprobacion
        public bool ValidarPro(double num1)
        {
            bool validar = false;
            if(num1 >= 7)
            {
                validar = true;  

            }
            return  validar;

        }

        #endregion
    }
}
