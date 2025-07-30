using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPilaresPoo_Pareja.Clases.Ejercicio6
{
    public class NotaCredito : DocumentoFiscal
    {
        public decimal MontoAjuste { get; set; }

        public NotaCredito(string numero, decimal montoAjuste) : base(numero)
        {
            MontoAjuste = montoAjuste;
        }

        public override string GenerarPDF()
        {
            return $"Generando PDF para Nota de Crédito {Numero} con ajuste de ${MontoAjuste:F2}";
        }
    }
}