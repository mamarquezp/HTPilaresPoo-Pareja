using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPilaresPoo_Pareja.Clases.Ejercicio6
{
    public class NotaDebito : DocumentoFiscal
    {
        public decimal MontoAdicional { get; set; }

        public NotaDebito(string numero, decimal montoAdicional) : base(numero)
        {
            MontoAdicional = montoAdicional;
        }

        public override string GenerarPDF()
        {
            return $"Generando PDF para Nota de Débito {Numero} con adicional de ${MontoAdicional:F2}";
        }
    }
}