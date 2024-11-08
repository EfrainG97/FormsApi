using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApi.Model
{
    internal class Alumno
    {
        public Alumno(int iD, string nombre, int edad, DateTime fechaNacimiento)
        {
            ID = iD;
            Nombre = nombre;
            Edad = edad;
            FechaNacimiento = fechaNacimiento;
        }

        public Alumno() { }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }

    }
}
