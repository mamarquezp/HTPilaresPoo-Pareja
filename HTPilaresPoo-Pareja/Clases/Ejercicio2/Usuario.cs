using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPilaresPoo_Pareja.Clases.Ejercicio2
{
    public class Usuario
    {
        //propiedades privadas para protegerlas
        private string dpi= "0000000000000";
        private string contraseña = "000000";
        
        //propiedad pública
        public string Nombre { get; set; } = "Usuario";

        public string DPI
        {
            get { return dpi; }
            set
            {
                if (value.Length == 13 && value.All(char.IsDigit))
                {
                    dpi = value;
                    Console.WriteLine($"DPI guardado");
                }
                else
                {
                    Console.WriteLine("DPI debe tener exactamente 13 dígitos.");
                }
            }
        }
        public string Contraseña
        {
            set
            {
                if (value.Length >= 6)
                {
                    contraseña = value;
                    Console.WriteLine("Contraseña asignada correctamente.");
                }
                else
                {
                    Console.WriteLine("La contraseña debe tener al menos 6 caracteres.");
                }
            }
        }
        public bool Autenticar(string input)
        {
            return input == contraseña;
        }
    }
}
