using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infija_PostijaV3
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Conversion ecuacion1 = new Conversion();
                ecuacion1.Inicializar();
                ecuacion1.conversion();
                Console.Write("¿Convertir otra notacion infija? s/n: ");
                opcion = Console.ReadLine();
                if (opcion == "n")
                    break;
                Console.Clear();
            } while (opcion == "s");
            Console.Clear();
            Console.WriteLine("--Creditos--");
            Console.WriteLine("Abelardo Garcia Reyes");
            Console.WriteLine("Cristian Sebastian Avitia");
            Console.ReadKey();
        }
    }
}
