/*EEjercicio 5: Sistema escolar con personas y perfiles diferenciados
Aplicar abstracción mediante una clase base y sobrescritura de métodos.
Diseña una clase abstracta Persona con atributo Nombre y método abstracto
MostrarPerfil().
Luego, crea dos clases concretas: Estudiante y Maestro, que implementen ese método de
forma diferente.
Finalmente, implementa una clase Escuela que almacene múltiples Persona y muestre sus
perfiles.
Este ejercicio refuerza cómo abstraer un concepto común (persona) y delegar el
comportamiento a las subclases.*/

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