using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    public class AlquilerOpcional02 : AlquilerOpcional01
    {
        private List<Juez> _jueces;

        public List<Juez> Jueces
        {
            get { return _jueces; }
        }

        public AlquilerOpcional02(Cancha cancha, decimal cantidadHoras, DateTime hora, Juez juez, List<Juez> jueces) : base(cancha, cantidadHoras, hora, juez)
        {
            _jueces = jueces;
            foreach (var j in _jueces)
            {
                j.Pago = 35;
            }
        }

        protected override decimal CalcularMonto()
        {
            return base.CalcularMonto() + 90;
        }
    }
}
