using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsApi.Model;

namespace FormsApi.Controller
{
    internal interface IAlumno
    {
        Task<List<Alumno>> GetAlumnos();

        Task<bool> AgregarAlumno(Alumno alumno);

        Task<bool> EliminarAlumno(int id);

        Task<bool> ActualizarAlumno(int id, Alumno alumno);

        Task<Alumno> ObtenerAlumnoID(int id);
    }
}
