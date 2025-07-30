using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPilaresPoo_Pareja.Clases.Ejercicio4
{
    public class Motocicleta : Vehiculo
    {
        public Motocicleta(string marca, string modelo) : base(marca, modelo)
        {
        }

        public override string Encender()
        {
            return $"La motocicleta {Marca} {Modelo} arranca con un sonido potente.";
        }

        public override string Conducir()
        {
            return $"La motocicleta {Marca} {Modelo} se inclina ágilmente en las curvas con sus dos ruedas.";
        }
    }
}
