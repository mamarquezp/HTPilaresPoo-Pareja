using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPilaresPoo_Pareja.Clases.Ejercicio4
{
    public class Carro : Vehiculo
    {
        public Carro(string marca, string modelo) : base(marca, modelo)
        {
        }

        public override string Encender()
        {
            return $"El carro {Marca} {Modelo} enciende con un sonido suave del motor.";
        }

        public override string Conducir()
        {
            return $"El carro {Marca} {Modelo} se desplaza cómodamente por la carretera con sus cuatro ruedas.";
        }
    }
}