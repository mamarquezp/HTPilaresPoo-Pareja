using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPilaresPoo_Pareja.Clases.Ejercicio6
{
    public class GestorDocumentos
    {
        private List<DocumentoFiscal> documentos;

        public GestorDocumentos()
        {
            documentos = new List<DocumentoFiscal>();
        }

        public void AgregarDocumento(DocumentoFiscal documento)
        {
            documentos.Add(documento);
        }

        public void GenerarTodosPDFs()
        {
            if (documentos.Count == 0)
            {
                Console.WriteLine("No hay documentos para generar.");
                return;
            }

            Console.WriteLine("Generación de PDFs:");
            foreach (var documento in documentos)
            {
                Console.WriteLine(documento.GenerarPDF());
            }
        }
    }
}