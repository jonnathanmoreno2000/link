using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculoComponente
{
    enum  TipoMotor
    { 
        DOS_TIEMPOS, CUATRO_TIEMPOS
    }

    class Motor : VehiculoComponente
    {
        private readonly int _id;
        private  TipoMotor _tipo;
        private double _cilindrada;
        

        public Motor( int Id , TipoMotor Tipo, double Cilindrada)
        {

            _id = Id;
            _tipo = Tipo;
            _cilindrada = Cilindrada;
        }

        public int Id => _id;


        public TipoMotor Tipo => _tipo;


        public double Cilindrada
        {
            get => Cilindrada;
            set => double.TryParse(value.ToString(), out _cilindrada);
        }

    
    
    
    
    
    }
}
