using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_estructura.Entity
{
    public class Alumno
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Grado { get; set; }
        public double Promedio { get; set; }
    }
}
