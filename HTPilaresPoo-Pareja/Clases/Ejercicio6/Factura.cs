using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPilaresPoo_Pareja.Clases.Ejercicio6
{
    public class Factura : DocumentoFiscal
    {
        public decimal Monto { get; set; }

        public Factura(string numero, decimal monto) : base(numero)
        {
            Monto = monto;
        }

        public override string GenerarPDF()
        {
            return $"Generando PDF para Factura {Numero} con monto ${Monto:F2}";
        }
    }
}