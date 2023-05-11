using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    public class Alquiler
    {
        private Cancha _cancha;

        public Cancha Cancha
        {
            get { return _cancha; }
        }

        private decimal _cantidadHoras;

        public decimal CantidadHoras
        {
            get { return _cantidadHoras; }
        }

        private DateTime _hora;
            
        public DateTime Hora
        {
            get { return _hora; }
        }


        public Alquiler(Cancha cancha, decimal cantidadHoras, DateTime hora)
        {
            _cancha = cancha;
            _cantidadHoras = cantidadHoras;
            _hora = hora;
            _monto = CalcularMonto();
            SetearValoresCancha();
        }

        private decimal _monto;

        public decimal Monto
        {
            get { return _monto;}
        }

        protected virtual decimal CalcularMonto()
        {
           
            return _cancha.Precio * _cantidadHoras;
        }

        private void SetearValoresCancha()
        {
            _cancha.Recaudacion = CalcularMonto();
            _cantidadHoras ++;
        }

    }
}
