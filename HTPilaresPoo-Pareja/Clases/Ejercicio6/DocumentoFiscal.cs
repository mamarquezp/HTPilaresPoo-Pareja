using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPilaresPoo_Pareja.Clases.Ejercicio6
{
    public abstract class DocumentoFiscal
    {
        public string Numero { get; set; }

        protected DocumentoFiscal(string numero)
        {
            Numero = numero;
        }

        public abstract string GenerarPDF();
    }
}