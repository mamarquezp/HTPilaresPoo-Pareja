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