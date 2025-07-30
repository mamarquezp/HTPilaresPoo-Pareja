using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPilaresPoo_Pareja.Clases.Ejercicio5
{
    public class Maestro : Persona
    {
        public string Materia { get; set; }

        public Maestro(string nombre, string materia) : base(nombre)
        {
            Materia = materia;
        }

        public override string MostrarPerfil()
        {
            return $"Maestro: {Nombre}, Materia: {Materia}";
        }
    }
}