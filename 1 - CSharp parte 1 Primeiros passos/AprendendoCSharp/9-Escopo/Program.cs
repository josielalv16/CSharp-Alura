using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 20;
            bool acompanhado = true;
            string mensagemAdicional;

            if(acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado";
            }
            else
            {
                mensagemAdicional = "João não está acompanhado";
            }

            if (idade >= 18 || acompanhado == true)
            {
                Console.WriteLine("Você tem mais que 18 anos");
                Console.WriteLine("Seja bem vindo");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
