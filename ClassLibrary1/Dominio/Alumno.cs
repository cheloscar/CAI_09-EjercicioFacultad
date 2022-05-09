using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_09_EjercicioFacultad.Librerias.Dominio
{
    public class Alumno : Persona
    {
        private int _codigo;

        public int Codigo { get => _codigo; }
        public Alumno(string nombre, string apellido, DateTime fechaNac, int codigo) 
            : base (nombre, apellido, fechaNac)
        {
            _codigo = codigo;
        }
        public override string GetCredencial()
        {
            return $"Código ({_codigo}) {this._apellido}, {_nombre}";
        }
        public override string ToString()
        {
            return this.GetCredencial();
        }
        public string Credencial()
        {
            return $"Código ({_codigo}) {this._apellido}, {_nombre}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != typeof(Empleado))
                return false;
            else
            {
                Alumno _tempAlumno = (Alumno)obj;
                if (this._codigo == _tempAlumno._codigo) return true;
                else return false;
            }
        }
    }
}
