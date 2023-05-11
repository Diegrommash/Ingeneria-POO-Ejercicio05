using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    public class AlquilerOpcional01 : Alquiler
    {
        private Juez _juez;

        public Juez Juez
        {
            get { return _juez; }
        }

        public AlquilerOpcional01(Cancha cancha, decimal cantidadHoras, DateTime hora, Juez juez) : base(cancha, cantidadHoras, hora)
        {
            _juez = juez;
            _juez.Pago = 50;
        }

        protected override decimal CalcularMonto()
        {
            return base.CalcularMonto() + 100;
        }
    }
}
