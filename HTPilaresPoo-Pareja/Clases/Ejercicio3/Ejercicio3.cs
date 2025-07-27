/*Ejercicio 3: Inventario controlado sin duplicados

PROGRAMACIÓN II

Encapsular la lógica interna de una estructura de datos y evitar inconsistencias.
Crea una clase Inventario que administre productos. Cada producto se representa por un
nombre y cantidad.
La clase debe permitir:
Agregar productos nuevos o incrementar la cantidad si ya existen.
Retirar cantidades específicas si están disponibles.
Mostrar el inventario completo.
Evita:
Cantidades negativas.
Duplicación de productos.
Acceso directo a la estructura interna (usar métodos públicos exclusivamente).*/

using HTPilaresPoo_Pareja.Clases.Ejercicio3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPilaresPoo_Pareja.Clases.Ejercicio3
{
    public static class Ejercicio3
    {
        public static void Ejecutar()
        {
            var nuevoInventario = new Inventario();

            nuevoInventario.MostrarInventario();

            nuevoInventario.AgregarProducto("Tornillos", 100);
            nuevoInventario.AgregarProducto("Tuercas", 150);

            nuevoInventario.AgregarProducto("Tornillos", 50);// Aumenta tornillos
            nuevoInventario.MostrarInventario();
            
            nuevoInventario.RetirarProducto("Tuercas", 20); // Retiro válido
            nuevoInventario.RetirarProducto("Tornillos", 200); // Inválido
            nuevoInventario.RetirarProducto("Martillos", 5); // Inválido
            nuevoInventario.MostrarInventario();
        }
    }
}
