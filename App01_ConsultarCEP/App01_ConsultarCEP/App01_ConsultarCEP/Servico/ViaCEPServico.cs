using App01_ConsultarCEP.Servico.Modelo;
using Newtonsoft.Json;
using System.Net;

namespace App01_ConsultarCEP.Servico
{
    public class ViaCEPServico
    {

        private static string _enderecoURL = "https://viacep.com.br/ws/{0}/json/";
        
        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            
            var novoEnderecoUrl = string.Format(_enderecoURL, cep);

            using (var webClient = new WebClient())
            {
                string conteudo = webClient.DownloadString(novoEnderecoUrl);

                var endereco = JsonConvert.DeserializeObject<Endereco>(conteudo);

                return endereco;

            }
        }

    }
}
