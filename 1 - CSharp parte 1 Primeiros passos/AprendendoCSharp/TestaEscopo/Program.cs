using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaEscopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("testando condicionais");

            int idade = 20;
            int quantidadePessoas = 3;
            bool acompanhado;

            if (quantidadePessoas >= 2)
            {
                acompanhado = true;
            }
            else
            {
                acompanhado = false;
            }

            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("infelizmente voce nao pode entrar");
            }
        }
    }
}
