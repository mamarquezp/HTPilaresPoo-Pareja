using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPilaresPoo_Pareja.Clases.Ejercicio3
{
    public class Inventario
    {
        // privado para que no pueda accederse desde afuera
        private Dictionary<string, int> productos;

        public Inventario()
        {
            productos = new Dictionary<string, int>(); //dictionary permite crear claves que no se repiten
        }

        public void AgregarProducto(string nombre, int cantidad)
        {
            if (cantidad <= 0) //validar que no sea 0 o negativo
            {
                Console.WriteLine("La cantidad debe ser positiva.");
                return;
            }

            if (productos.ContainsKey(nombre)) //si y aexiste, agrega cantidad a existentes
            {
                productos[nombre] += cantidad;
                Console.WriteLine($"Se agregaron {cantidad} unidades de '{nombre}'. Stock actual: {productos[nombre]}");
            }
            else
            {
                productos.Add(nombre, cantidad);
                Console.WriteLine($"Producto nuevo '{nombre}' agregado con {cantidad} unidades");
            }
        }

        public void RetirarProducto(string nombre, int cantidad)
        {
            if (cantidad <= 0)//revisa que sea un número positivo
            {
                Console.WriteLine("La cantidad a retirar debe ser positiva");
                return;
            }

            if (!productos.ContainsKey(nombre))//revisa si existe
            {
                Console.WriteLine($"El producto '{nombre}' no existe en el inventario");
                return;
            }

            if (productos[nombre] < cantidad)//revisa que haya suficiente
            {
                Console.WriteLine($"No hay suficiente stock de '{nombre}'. Solicitado: {cantidad}, Disponible: {productos[nombre]}");
                return;
            }

            productos[nombre] -= cantidad;
            Console.WriteLine($"Se retiraron {cantidad} unidades de '{nombre}'. Stock restante: {productos[nombre]}");
        }

        public void MostrarInventario()
        {
            Console.WriteLine("--- Inventario Actual ---");
            if (productos.Count == 0)
            {
                Console.WriteLine("El inventario está vacío.");
            }
            else
            {
                foreach (var producto in productos)
                {
                    Console.WriteLine($"-> {producto.Key}: {producto.Value} unidades");
                }
            }
            Console.WriteLine("-------------------------");
        }
    }
}
