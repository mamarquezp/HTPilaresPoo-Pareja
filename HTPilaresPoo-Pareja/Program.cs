using HTPilaresPoo_Pareja.Clases.Ejercicio1;
using HTPilaresPoo_Pareja.Clases.Ejercicio2;
using HTPilaresPoo_Pareja.Clases.Ejercicio3;
using System;

public class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Selecciona el ejercicio a ejecutar:");
        Console.WriteLine("1. Ejercicio de Biblioteca");
        Console.WriteLine("2. Ejercicio de Usuario con Validación");
        Console.WriteLine("3. Ejercicio de Inventario Controlado");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                Ejercicio1.Ejecutar();
                break;
            case "2":
                Ejercicio2.Ejecutar();
                break;
            case "3":
                Ejercicio3.Ejecutar();
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}
