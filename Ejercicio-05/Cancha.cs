using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    public class Cancha
    {
        private string _tipo;

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private decimal _precio;

        public decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        private decimal _recaudacion;

        public decimal Recaudacion
        {
            get { return _recaudacion; }
            set { _recaudacion = value; }
        }

        private int _cantidadAlquileres;

        public int CantidadAlquileres
        {
            get { return _cantidadAlquileres; }
            set { _cantidadAlquileres = value; }
        }




    }
}
