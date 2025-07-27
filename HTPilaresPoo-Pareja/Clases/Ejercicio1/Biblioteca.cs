using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPilaresPoo_Pareja.Clases.Ejercicio1
{
    public class Biblioteca
    {
        private List<Libro> libros;
        private int idContador = 1;
        public Biblioteca()
        {
            libros = new List<Libro>();
        }
        public void RegistrarLibro(string titulo, string autor)
        {
            if (!libros.Any(l => l.titulo == titulo))
            {
                var nuevoLibro = new Libro(titulo, autor);
                nuevoLibro.id = idContador;

                libros.Add(nuevoLibro);
                idContador++;
            }
            else
            {
                Console.WriteLine("El libro ya está registrado.");
            }
        }
        public void PrestarLibro(string titulo, string usuario)
        {
            var libro = libros.FirstOrDefault(l => l.titulo == titulo && l.disponible);
            if (libro != null)
            {
                libro.disponible = false;
                libro.usuarioPrestamo = usuario;
            }
            else
            {
                Console.WriteLine("El libro no está disponible o no existe.");
            }
        }
        public void ObtenerLibrosDisponibles()
        {
          foreach (var libro in libros)
            {
                Console.WriteLine($"[ID: {libro.id}] - Título: {libro.titulo}, Autor: {libro.autor}, Disponible {libro.disponible}");
            }
        }
    }
}
