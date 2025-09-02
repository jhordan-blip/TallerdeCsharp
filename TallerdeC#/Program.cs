using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerdeC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir mensaje 
            Console.WriteLine("Bienvenido a C#");

            //-- Definir variables --
            int a, b, producto;

            //-- Entrada de Datos --
            Console.WriteLine("Ingrese primer numero");
            //-- Guardar valor en la consola -- 
            a = int.Parse(Console.ReadLine());
            //a = init.TryParse(Console.ReadLine()); // Boolean True o False

            Console.WriteLine("Ingrese segundo numero");
            //Guardar valor de la consola
            b = Convert.ToInt32((Console.ReadLine()));
            //b = init.TryParse(Console.ReadLine()): //Boolean

            //-- Proceso -- 
            producto = a * b;

            //-- Salida de datos -- 
            Console.WriteLine("El producto es: " + producto);
            Console.WriteLine($"El producto de {a} * {b} = {producto}");

            //Detener la pantalla para mostrar el resultado 
            Console.ReadLine();

        }
    }
}
