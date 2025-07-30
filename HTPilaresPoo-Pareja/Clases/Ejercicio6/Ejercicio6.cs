/*Ejercicio 6: Sistema de documentos fiscales con generación de reportes
Aplicar abstracción y polimorfismo en un contexto profesional.
Define una clase abstracta DocumentoFiscal con un método GenerarPDF() y atributo
Numero.
Luego, crea subclases: Factura, NotaCredito, NotaDebito, cada una con una implementación
propia del método.
Crea una clase GestorDocumentos que reciba una lista de documentos y ejecute
GenerarPDF() sin importar su tipo específico.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPilaresPoo_Pareja.Clases.Ejercicio6
{
    public class Ejercicio6
    {
        public static void Ejecutar()
        {
            GestorDocumentos gestor = new GestorDocumentos();

            gestor.AgregarDocumento(new Factura("F001", 1500.50m));
            gestor.AgregarDocumento(new NotaCredito("NC001", 200.75m));
            gestor.AgregarDocumento(new NotaDebito("ND001", 300.25m));

            gestor.GenerarTodosPDFs();
        }
    }
}