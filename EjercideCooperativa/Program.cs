using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercideCooperativa
{
    class Program
    {
        static void Main(string[] args)


        {

            int v, t, d, autobus;
            Console.Write(" Escriba el nombre de la ruta: ");
            autobus = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese velocidad:");
            v = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese distancia:");
            d = int.Parse(Console.ReadLine());

            t = v * d;

            Console.WriteLine("El tiempo es = {0}", t);
            Console.ReadKey();





        }
    }
}
