using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    public class Juez
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private string _legajo;

        public string Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }

        private decimal _pago;

        public decimal Pago
        {
            get { return _pago; }
            set { _pago = value; }
        }



    }
}
