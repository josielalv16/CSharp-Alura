using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(876, 86712540);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}
