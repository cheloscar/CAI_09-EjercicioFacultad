using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_09_EjercicioFacultad.Librerias.Excepciones
{
    internal class ElAlumnoYaExisteException : Exception
    {
        public ElAlumnoYaExisteException() : base("Está intentando agregar un alumno que ya existe.") { }
    }
}
