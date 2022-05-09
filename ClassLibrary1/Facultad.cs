using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAI_09_EjercicioFacultad.Librerias.Dominio;
using CAI_09_EjercicioFacultad.Librerias.Excepciones;

namespace CAI_09_EjercicioFacultad
{
    internal class Facultad
    {
        List<Alumno> _alumnos;
        List<Empleado> _empleados;
        string _nombre;
        int _cantidadSedes;
        
        public Facultad(string nombre, int cantSedes)
        {
            _alumnos = new List<Alumno>();
            _empleados = new List<Empleado>();
            _nombre = nombre;
            _cantidadSedes = cantSedes;
        }
        public string Nombre { get => _nombre; }
        public int CantidadSedes { get => _cantidadSedes; }
        public void AgregarAlumno(Alumno alumno)
        {
            bool _existe = false;
            if (alumno == null)
                throw new ArgumentNullException(nameof(alumno));
            foreach(Alumno alumno1 in _alumnos)
            {
                if (alumno1.Equals(alumno)) { _existe = true; break; }
                    
            }
            if (!_existe) { _alumnos.Add(alumno); }
        }
        public  void AgregarAlumno(string nombre, string apellido, DateTime fechaNac, int codigo)
        {
            Alumno _alumno = new Alumno(nombre, apellido, fechaNac, codigo);
            AgregarAlumno(_alumno);
        }
        public void AgregarEmpleado(Empleado empleado)
        {
            bool _existe = false;
            if (empleado == null)
                throw new ArgumentNullException(nameof(empleado));
            foreach (Empleado empleado1 in _empleados)
            {
                if (empleado1.Equals(empleado))
                {
                    _existe = true;
                    _empleados[_empleados.IndexOf(empleado1)] = empleado;
                    break;
                }
            }
            if (!_existe) { _empleados.Add(empleado); }
        }
        public void EliminarAlumno(int codigo)
        {
            foreach(Alumno alumno in _alumnos)
            {
                if (alumno.Codigo == codigo)
                {
                    _alumnos.Remove(alumno);
                }
            }
        }
        public void EliminarEmpleado(int codigo)
        {
            foreach (Alumno empleado in _alumnos)
            {
                if (empleado.Codigo == codigo)
                {
                    _alumnos.Remove(empleado);
                }
            }
        }
    }
}
