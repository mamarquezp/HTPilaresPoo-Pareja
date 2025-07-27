using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPilaresPoo_Pareja.Clases.Ejercicio1
{
    public class Libro
    {
        // public para que puedan accederse desde fuera para leer los valores, pero modificables solo desde dentro de la clase
        public string titulo { get; internal set; }
        public string autor { get; internal set; }
        public bool disponible { get; set; }
        public double id { get; internal set; }
        public string usuarioPrestamo { get; internal set; }

        public Libro(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.disponible = true;
            id = 0;
            usuarioPrestamo = "";
        }
    }
}
