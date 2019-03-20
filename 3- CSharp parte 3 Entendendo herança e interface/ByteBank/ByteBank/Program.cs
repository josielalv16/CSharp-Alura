using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000, "546.879.157-20");

            carlos.Nome = "Carlos";

            carlos.AumentarSalario();
            Console.WriteLine("Novo salario do Carlos " + carlos.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor(5000, "454.658.148-3");
            roberta.Nome = "Roberta";

            roberta.AumentarSalario();
            Console.WriteLine("Novo salario da Roberta " + roberta.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificação de uma refenrecia de Diretor: " + roberta.GetBonificacao());

            Console.WriteLine("Bonificação de uma refenrecia de Funcionario: " + robertaTeste.GetBonificacao());

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
