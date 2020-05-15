using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculoComponente
{
   enum TipoRecubrimiento
    {
        FENOL, HULE, POLIUTERANO
    }

    class Rueda : VehiculoComponente
    {
        private TipoRecubrimiento _recubrimiento;
        private int numRuedas;
        private readonly int[] _Durometro;


        public Rueda(TipoRecubrimiento Recubrimiento, int MinDurometro, int MaxDurometro)
        {
            _recubrimiento = Recubrimiento;

            _Durometro = new int[] { MinDurometro, MaxDurometro };
            Durometro = _Durometro; 
        }

        public Rueda(int numRuedas)
        {
            this.numRuedas = numRuedas;
        }

        public TipoRecubrimiento _Recubrimiento
        {
            get => _Recubrimiento;
            set => Enum.TryParse(value.ToString(), result: out _recubrimiento);

        }

        public int[] Durometro {
            get { return _Durometro; }
            set { 
                if (value.GetType().IsArray)
                    if (_Durometro[0] <= _Durometro[1])
                    {

                        _Durometro[0] = value[0];
                        _Durometro[1] = value[1];
                    }
                else
                    {

                        _Durometro[0] = -1;
                        _Durometro[1] = -1;
                    }
            }

        }

    }
}
