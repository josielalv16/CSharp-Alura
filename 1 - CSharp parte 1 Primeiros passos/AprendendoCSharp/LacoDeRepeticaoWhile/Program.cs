using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoDeRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;  //mais usado!
            }
            Console.ReadLine();
        }
    }
}
