using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("testando condicionais");

            int idade = 20;
            //int quantidadePessoas = 3;
            //bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = false;

            if (idade >= 18 && acompanhado == true)
            {
                Console.WriteLine("Você tem mais que 18 anos");
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
