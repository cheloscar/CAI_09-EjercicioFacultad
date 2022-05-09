using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_09_EjercicioFacultad.Librerias.Dominio
{
    internal abstract class Empleado : Persona
    {
        DateTime _fechaIngreso;
        int _legajo;
        List<Salario> _salarios = new List<Salario>();
        public Empleado(string nombre, string apellido, DateTime fechaNac, DateTime fechaIngreso, int legajo)
            : base(nombre, apellido, fechaNac)
        {
            _fechaIngreso = fechaIngreso;
            _legajo = legajo;
        }
        public Empleado(string nombre, string apellido, DateTime fechaNac, DateTime fechaIngreso, int legajo, Salario salario) 
            : base (nombre, apellido, fechaNac)
        {
            _fechaIngreso = fechaIngreso;
            _legajo = legajo;
            _salarios.Add(salario);
        }
        public DateTime FechaIngreso { get => _fechaIngreso; }
        public int Legajo { get => _legajo; }
        public DateTime FechaNacimiento { get => _fechaIngreso; }
        public int Antiguedad()
        {
            return DateTime.Now.Year - _fechaIngreso.Year; 
        }
        public List<Salario> Salarios { get => _salarios; }
        public Salario UltimoSalario { get => _salarios.Last(); }
        public void AgregarSalario(Salario salario)
        {
            _salarios.Add(salario);
        }
        public override string GetCredencial()
        {
            return $"{this._legajo} - {GetNombreCompleto()}";
        }
        public new string GetNombreCompleto()
        {
            return $"{this.Nombre} {this.Apellido}";
        }
        public override string ToString()
        {
            return GetCredencial();
        }
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != typeof(Empleado))
                return false;
            else
            {
                Empleado _tempEmpleado = (Empleado)obj;
                if (this._legajo == _tempEmpleado._legajo) return true;
                else return false;
            }
        }
    }
}
