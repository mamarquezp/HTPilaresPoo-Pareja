/*Ejercicio 2: Usuario con validación de campos sensibles
Aplicar reglas de validación dentro de propiedades y proteger datos privados.
Crea una clase Usuario con los siguientes atributos:
Nombre (público)
DPI (debe validarse: exactamente 13 dígitos)
Contraseña (mínimo 6 caracteres; solo se puede asignar, no leer directamente)
Además, incluye un método Autenticar(string input) que verifique si la contraseña ingresada
coincide. La clase debe garantizar que ningún dato sensible sea accesible directamente, sino
solo mediante propiedades o métodos controlados.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPilaresPoo_Pareja.Clases.Ejercicio2
{
    public static class Ejercicio2
    {
        public static void Ejecutar()
        {
            var usuario = new Usuario { Nombre = "Ana" };
            Console.WriteLine($"Usuario creado");


            Console.WriteLine("--- DPI ---");
            usuario.DPI = "12345"; // Inválido
            usuario.DPI = "1234567890ABC"; // Inválido
            usuario.DPI = "1234567890123"; // Válido
            
            Console.WriteLine("--- Contraseña ---");
            usuario.Contraseña = "123"; // Inválida
            usuario.Contraseña = "Miclavecorrecta123"; // Válida
            
            Console.WriteLine("--- Autenticación ---");
            bool resultado1 = usuario.Autenticar("claveIncorrecta");
            Console.WriteLine($"Intento: {(resultado1 ? "Éxito" : "Fallido")}");

            bool resultado2 = usuario.Autenticar("Miclavecorrecta123");
            Console.WriteLine($"Intento: {(resultado2 ? "Éxito" : "Fallido")}");
        }
    }
}
