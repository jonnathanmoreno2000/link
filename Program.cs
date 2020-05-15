using System;
using System.Collections;
using System.Dynamic;

namespace vehiculoComponente
{
    class Program
    {




        static void Main(string[] args)
        {


            string infoautomoviles = string.Format(
                "ID => {0}\n" +
                "Tipo de motor => {1}\n" +
                "cilindrado => {2}\n" +
                "Numero de Ruedas => {3}\n" +
                "Tipo recubrimiento => {4}\n" +
                "Min durometro => {5}\n" +
                "Min durometro => {6}\n" +
                "Tipo mesclador => {7}\n" +
                "Capacidad estanque => {8}\n");

            ArrayList litaDeAutomoviles = new ArrayList();

            Console.WriteLine("Menu Automoviles Elija un Opcion");
            Console.WriteLine(" Opcion 1, ingresar vehiculo ");
            Console.WriteLine(" Opcion 2, Listar Vehiculos");
            Console.WriteLine(" Opcion 3, Salir");

            int opcion;
            bool resultadoOpcion = int.TryParse(Console.ReadLine(), out opcion);
            if (resultadoOpcion)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("ingrese la id del Motor");
                        int idMotor;
                        int.TryParse(Console.ReadLine(), out idMotor);
                        break;
                    case 2:
                        foreach (Automoviles automoviles in litaDeAutomoviles)
                        {
                            Console.WriteLine("el id es" + automoviles.Motor.ID);
                        }
                        break;
                    case 3:
                        Environment.Exit(0);

                        break;
                    default:
                        break;

                }
            }



        }
    }
}
    


