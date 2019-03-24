using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(514, 0);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Ocorreu uma exceção do tipo Argumento");
            }

            try
            {
                Metodo();
            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine("Não é possivel divisão por zero");
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine("Aconteceu um erro");
            }

            Console.ReadLine();
        }
        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(2);
        }

        private static void TestaDivisao(int divisor)
        {

            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);

        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exeçao com numero=" + numero + " e divisor=" + divisor);
                throw;
            }
            
        }
    }
}
