using System;
using System.Collections.Generic;
using System.Text;
using VehiculoComponente;

namespace vehiculoComponente
{
    abstract class Vehiculo
    {
        private Motor _Motor;
        private Rueda[] _ruedas;
        private Estanque _Estanque;
        private Mesclador _Mesclador;


        public Vehiculo(int idMotor, TipoMotor tipoMotor, int cilindrada,
            int numRuedas, TipoRecubrimiento tipoRecubrimiento,
            int minDurometro, int maxDurometro,
            TipoMesclador tipoMesclador, double capacidad)

        {

            _Motor = new Motor(idMotor, tipoMotor, cilindrada);


            _ruedas = new Rueda[numRuedas];
            for (int i = 0; i < numRuedas; i++)
                _ruedas[i] = new Rueda(tipoRecubrimiento, minDurometro, maxDurometro);

            _Estanque = new Estanque(capacidad);

            _Mesclador = new Mesclador(tipoMesclador);

        }

        internal Rueda[] Ruedas { get => _ruedas; set => _ruedas = value; }

        internal Estanque Estanque { get => _Estanque; set => _Estanque = value; }

        internal Mesclador Mesclador { get => _Mesclador; set => _Mesclador = value; }

        internal Motor Motor { get => _Motor; set => _Motor = value; }
    }
}

