using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerdeC_
{
    public class Ejemplo
    {
        public void areatriangulo() {

            //Definir variables
            //s = semiperimetro 
            //float s 
            //doble area

            //Solicitar datos
            Console.WriteLine("Ingrese el lado a: ");
            //Guardar datos 
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado b: ");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado c: ");
            var c = int.Parse(Console.ReadLine());

            //Proceso 
            var s = (a + b + c) / 2; 
            var area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            //Salida de datos 
            Console.WriteLine($"El area del triangulo es segun lados {a},{b},{c} es: {area} m2");

            //Detener pantalla para ver resultados
            Console.ReadKey();

        }


    }
}
