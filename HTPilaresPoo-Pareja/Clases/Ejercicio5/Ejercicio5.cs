using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPilaresPoo_Pareja.Clases.Ejercicio5
{
    public class Ejercicio5
    {
        public static void Ejecutar()
        {
            Escuela escuela = new Escuela();

            escuela.AgregarPersona(new Estudiante("Juan Pérez", 10));
            escuela.AgregarPersona(new Maestro("María López", "Matemáticas"));
            escuela.AgregarPersona(new Estudiante("Marlon Aguilar", 11));
            escuela.AgregarPersona(new Maestro("Jonatan Sandoval", "Programación"));

            escuela.MostrarPerfiles();
        }
    }
}