using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; set; }

        public ExtratorValorDeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio.", nameof(url));
            }

            URL = url;

            int indiceInterrogracao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogracao + 1);
        }

        public string GetValor(string nomeParametro)
        {
            int indiceParametro = _argumentos.IndexOf()
        }
    }
}
