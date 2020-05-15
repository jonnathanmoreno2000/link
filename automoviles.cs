using System;
using vehiculoComponente;
using VehiculoComponente;

namespace vehiculoComponente
{
    class Automoviles : Vehiculo
    {
        private string _marca;
        private int _ano;
        private int _kilometraje;

        public Automoviles(int idMotor, TipoMotor tipoMotor, int cilindrada,
            int numRuedas, TipoRecubrimiento tipoRecubrimiento,
            int minDurometro, int maxDurometro,
             TipoMesclador tipoMesclador, double capacidad, string marca, int ano, int kilometraje): base( idMotor,  tipoMotor, cilindrada,
             numRuedas,  tipoRecubrimiento,
             minDurometro,  maxDurometro,
             tipoMesclador,  capacidad)
        {
            Marca = marca;
            Ano = ano;
            Kilometraje = kilometraje;
        }

        public string Marca { get => _marca; set => _marca = value; }
        public int Ano { get => _ano; set => _ano = value; }
        public int Kilometraje { get => _kilometraje; set => _kilometraje = value; }
    }
}
