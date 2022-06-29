using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Programa principal");
            Planta.MinAgua = 30.0;
            Planta.rand = new Random();

            Jardin jardin = new Jardin("terraza", 10);


            jardin.tiempo();

            Console.WriteLine("Pulse una tecla para finalizar");
            Console.ReadLine();
        
        }
    }
}
