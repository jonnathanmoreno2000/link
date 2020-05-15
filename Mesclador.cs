using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculoComponente
{

    enum TipoMesclador
    {
        CARBURADOR, INYECTORES
    }


    class Mesclador : VehiculoComponente

    
    {
      
        private TipoMesclador _Tipo;


        public Mesclador(TipoMesclador Tipo)
        {
            _Tipo = Tipo;
        }



        public string Tipo{
            get { return _Tipo.ToString(); }
            set
            {
                Enum.TryParse(value, out _Tipo);
            }

        }
    }
}
