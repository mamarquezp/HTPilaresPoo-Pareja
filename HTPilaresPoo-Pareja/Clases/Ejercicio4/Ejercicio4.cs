/*Ejercicio 4: Jerarquía de vehículos con clase abstracta
Utilizar clases abstractas para definir comportamientos comunes en tipos de objetos relacionados.
Crea una clase abstracta Vehiculo con métodos Encender() y Conducir().
Luego, implementa dos clases concretas: Carro y Motocicleta.
Cada tipo debe definir un comportamiento distinto al conducir.
Crea una lista de Vehiculo y recórrela para probar el comportamiento polimórfico.*/

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