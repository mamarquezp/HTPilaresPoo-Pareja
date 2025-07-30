using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPilaresPoo_Pareja.Clases.Ejercicio5
{
    public class Escuela
    {
        private List<Persona> personas;

        public Escuela()
        {
            personas = new List<Persona>();
        }

        public void AgregarPersona(Persona persona)
        {
            personas.Add(persona);
        }

        public void MostrarPerfiles()
        {
            if (personas.Count == 0)
            {
                Console.WriteLine("No hay personas registradas en la escuela.");
                return;
            }

            Console.WriteLine("Perfiles de las personas en la escuela:");
            foreach (var persona in personas)
            {
                Console.WriteLine(persona.MostrarPerfil());
            }
        }
    }
}