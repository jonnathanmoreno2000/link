using System;
using System.Collections.Generic;
using System.Text;

namespace vehiculoComponente
{
    class Estanque
    {
        private double _litros;


        public Estanque(double capacidad)
        {
            capacidad = capacidad;

        }

        public double capacidad => capacidad;


        public double litros
        {

            get => _litros;
            set => double.TryParse(value.ToString(), out _litros);
        }


        public bool bajoCombustible()
        {
            return _litros <= 10.5;
        }


        public bool mitadCombustible()
        {
            return _litros > 10.5 && _litros <= 50.0;
        }
            
        
    }
}
