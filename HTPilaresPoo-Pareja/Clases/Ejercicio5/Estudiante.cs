using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPilaresPoo_Pareja.Clases.Ejercicio5
{
    public class Estudiante : Persona
    {
        public int Grado { get; set; }

        public Estudiante(string nombre, int grado) : base(nombre)
        {
            Grado = grado;
        }

        public override string MostrarPerfil()
        {
            return $"Estudiante: {Nombre}, Grado: {Grado}";
        }
    }
}