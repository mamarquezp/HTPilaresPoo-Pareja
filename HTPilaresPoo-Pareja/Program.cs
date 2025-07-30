using HTPilaresPoo_Pareja.Clases.Ejercicio1;
using HTPilaresPoo_Pareja.Clases.Ejercicio2;
using HTPilaresPoo_Pareja.Clases.Ejercicio3;
using HTPilaresPoo_Pareja.Clases.Ejercicio4;
using HTPilaresPoo_Pareja.Clases.Ejercicio5;
using HTPilaresPoo_Pareja.Clases.Ejercicio6;
using System;

public class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Selecciona el ejercicio a ejecutar:");
        Console.WriteLine("1. Ejercicio de Biblioteca");
        Console.WriteLine("2. Ejercicio de Usuario con Validación");
        Console.WriteLine("3. Ejercicio de Inventario Controlado");
        Console.WriteLine("4. Ejercicio de Jerarquía de Vehículos con clase Abstracta");
        Console.WriteLine("5. Ejercicio de Sistema escolar con personas y perfiles diferenciados");
        Console.WriteLine("6. Ejercicio de Sistema de documentos fiscales con generación de reportes");


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
                case "4":
                Ejercicio4.Ejecutar();
                break;
                case "5":
                Ejercicio5.Ejecutar();
                break;
                case "6":
                Ejercicio6.Ejecutar();
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}