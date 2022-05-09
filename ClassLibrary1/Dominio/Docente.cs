using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_09_EjercicioFacultad.Librerias.Docente
{
    internal sealed class Docente : Empleado
    {
        public Docente(string nombre, string apellido, DateTime fechaNac, DateTime fechaIngreso, int legajo)
            : base (nombre, apellido, fechaNac, fechaIngreso, legajo)
        {
        }
        public Docente(string nombre, string apellido, DateTime fechaNac, DateTime fechaIngreso, int legajo, Salario salario)
            : base(nombre, apellido, fechaNac, fechaIngreso, legajo, salario)
        {
        }
        public new string GetNombreCompleto()
        {
            return $"Docente {this._nombre}";
        }
    }
}
