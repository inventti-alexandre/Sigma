using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.APIs.Correio
{
    class CorreioModel
    {
        public CorreioDTO Endereco(string CEP)
        {
            //Prepara URL
            string URL = $"https://viacep.com.br/ws/{CEP}/json";

            // Prepara cliente REST para fazer chamada
            WebClient rest = new WebClient();
            rest.Encoding = Encoding.UTF8;

            //Chamada Rest
            string data = rest.DownloadString(URL);
            var endereco = JsonConvert.DeserializeObject<CorreioDTO>(data);
            return endereco;
        }
    }
}
