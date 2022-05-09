using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_09_EjercicioFacultad.Librerias.Dominio
{
    internal class Salario
    {
        double _bruto;
        string _codigoTransferencia;
        double _descuentos;
        DateTime _fecha;
        public double Bruto { get => _bruto; set => _bruto = value; }
        public string CodigoTransferencia { get => _codigoTransferencia; set => _codigoTransferencia = value; }
        public double Descuentos { get => _descuentos; set => _descuentos = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }

        public double GetSalarioNeto()
        {
            return _bruto - _descuentos;
        }
        public Salario(double bruto)
        {
            _bruto = bruto;
        }
        public Salario(double bruto, string codigoTransferencia, double descuentos, DateTime fecha)
        {
            _bruto = bruto;
            _codigoTransferencia = codigoTransferencia;
            _descuentos = descuentos;
            _fecha = fecha;
        }

    }
}
