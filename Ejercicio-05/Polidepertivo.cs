using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    public class Polidepertivo
    {
        private List<Cancha> _canchas;
            
        public List<Cancha> Canchas
        {
            get { return _canchas; }
        }

        private List<Juez> _jueces;

        public List<Juez> Jueces
        {
            get { return _jueces; }
        }
        public Polidepertivo(List<Cancha> canchas, List<Juez> jueces)
        {
            _canchas = canchas;
            _jueces = jueces;
        }

        private List<Alquiler> _alquileres;

        public List<Alquiler> Alquileres
        {
            get { return _alquileres; }
            set { _alquileres = value; }
        }

        private decimal _recaudacionTotal;

        public decimal RecaudacionTotal
        {
            get
            {
                CalcularRecaudacionTotal();
                return _recaudacionTotal;
            }
        }

        private void CalcularRecaudacionTotal()
        {
            foreach (var cancha in _canchas)
            {
                _recaudacionTotal += cancha.Recaudacion;
            }
        }

        //voy por total jueces
    }
}
