/*Diseña una clase Biblioteca que administre una colección de libros y el registro de préstamos.
Cada libro tendrá: Título, Autor, Disponible (bool) y un identificador único.
La biblioteca debe permitir:
 -Registrar nuevos libros sin duplicar títulos.
 -Prestar libros solo si están disponibles.
 -Registrar el nombre del usuario que lo tomó prestado (internamente).
 -Mostrar los libros disponibles, sin exponer directamente las estructuras internas.
El acceso a los libros y préstamos debe estar encapsulado mediante métodos públicos y
validaciones internas.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPilaresPoo_Pareja.Clases.Ejercicio1
{
    public static class Ejercicio1
    {
        public static void Ejecutar()
        {
            var nuevaBiblioteca = new Biblioteca();

            nuevaBiblioteca.RegistrarLibro("Cien Años de Soledad", "Gabriel García Márquez");
            nuevaBiblioteca.RegistrarLibro("El Señor de los Anillos", "J.R.R. Tolkien");
            nuevaBiblioteca.RegistrarLibro("1984", "George Orwell");
            nuevaBiblioteca.RegistrarLibro("Cien Años de Soledad", "Gabo"); //duplicado

            nuevaBiblioteca.ObtenerLibrosDisponibles();

            nuevaBiblioteca.PrestarLibro("El Señor de los Anillos", "Ana"); // Préstamo exitoso
            nuevaBiblioteca.PrestarLibro("El Señor de los Anillos", "Pedro"); //libro ya prestado
            nuevaBiblioteca.PrestarLibro("El Señor Presidente", "Luis");// no existe

            nuevaBiblioteca.ObtenerLibrosDisponibles(); //ya no muestra el prestado

        }
    }
}
