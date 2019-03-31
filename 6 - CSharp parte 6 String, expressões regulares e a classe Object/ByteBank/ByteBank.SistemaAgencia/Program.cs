using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);
            Console.ReadLine();

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

            Console.WriteLine(extratorDeValores.GetValor("valor"));

            Console.ReadLine();

            //string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
            //ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            //string valor = extratorDeValores.GetValor("moedaDestino");
            //Console.WriteLine("Valor de moedaDestino: " + valor);
            //Console.ReadLine();

            string testeRemocao = "primeiraParte&parteParaRemover";
            int indiceComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceComercial));

            Console.ReadLine();

            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
            Console.ReadLine();



            string url = "pagina?argumentos";

            Console.WriteLine(url);
            string argumentos = url.Substring(6);
            Console.WriteLine(argumentos);
























            //DateTime dataFimPagamento = new DateTime(2019, 5, 16);
            //DateTime dataCorrente = DateTime.Now;

            //TimeSpan diferenca = dataFimPagamento - dataCorrente;

            //string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            //Console.WriteLine(dataCorrente);
            //Console.WriteLine(dataFimPagamento);

            //Console.WriteLine(mensagem);
            Console.ReadLine();
        }

        //static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        //{
        //    if (timeSpan.Days > 30)
        //    {
        //        int quantidadeMeses = timeSpan.Days / 30;
        //        if (quantidadeMeses == 1)
        //        {
        //            return "1 mes";
        //        }
        //        return quantidadeMeses + " meses";
        //    }
        //    else if (timeSpan.Days > 7)
        //    {
        //        int quantidadeSemanas = timeSpan.Days / 7;
        //    }
        //    return timeSpan.Days + " dias";
        //}
    }
}
