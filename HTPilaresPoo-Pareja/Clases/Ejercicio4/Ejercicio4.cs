using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPilaresPoo_Pareja.Clases.Ejercicio4
{
    public class Ejercicio4
    {
        public static void Ejecutar()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>
            {
                new Carro("Toyota", "Hilux"),
                new Motocicleta("Yamaha", "R6")
            };

            foreach (var vehiculo in vehiculos)
            {
                Console.WriteLine(vehiculo.Encender());
                Console.WriteLine(vehiculo.Conducir());
                Console.WriteLine();
            }
        }
    }
}