using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_09_EjercicioFacultad.Librerias.Dominio
{
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;
        DateTime _fechaNac;

        public string Nombre { get => _nombre; }
        public string Apellido { get => _apellido; }
        public int Edad()
        {
            return DateTime.Now.Year - _fechaNac.Year;
        }
        public Persona(string nombre, string apellido, DateTime fechaNac)
        {
            _nombre = nombre;
            _apellido = apellido;
            _fechaNac = fechaNac;
        }
        public abstract string GetCredencial();
        public string GetNombreCompleto()
        {
            return $"{_nombre} {_apellido}";
        }
    }
}
