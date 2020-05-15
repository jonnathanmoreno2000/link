using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculoComponente
{
    abstract class VehiculoComponente
    {
        private double _Estado;

        protected VehiculoComponente()
        {
            _Estado = 100.0;
        }

        public double Estado
        {

            get => _Estado;
            set => double.TryParse(value.ToString(), out _Estado);
        }

        private readonly int _Id;
        private readonly TipoMotor _tipo;
        private double _Cilindrada;



        public int ID => _Id;
    }
}
