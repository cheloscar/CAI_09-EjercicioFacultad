using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_09_EjercicioFacultad.Librerias.Dominio
{
    internal sealed class Bedel : Empleado
    {
        string _apodo;
        public Bedel(string nombre, string apellido, DateTime fechaNac, DateTime fechaIngreso, int legajo, string apodo)
            : base(nombre, apellido, fechaNac, fechaIngreso, legajo)
        {
            _apodo = apodo;
        }
        public Bedel(string nombre, string apellido, DateTime fechaNac, DateTime fechaIngreso, int legajo, string apodo, Salario salario)
            : base(nombre, apellido, fechaNac, fechaIngreso, legajo, salario)
        {
            _apodo = apodo;
        }

        public string Apodo { get => _apodo; }

        public new string GetNombreCompleto()
        {
            return $"Bedel {Apodo}";
        }
    }
}
