using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Tramita.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace Tramita.Service
{
    public class DadosAbertosSenadoFederalService
    {
        private static string UrlBase = "http://legis.senado.leg.br/dadosabertos/";
        private static string UrlListaSenador = "senador/lista/atual?v=4";
        private static string UrlObterSenador = "senador/{0}?v=5";

        public DadosAbertosSenadoFederalService()
        {

        }

        public static List<Senador> ListarSenadores()
        {
            // Pega o Json do Webservice
            WebClient webClient = new WebClient();
            webClient.Headers[HttpRequestHeader.Accept] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            string resposta = webClient.DownloadString(string.Format("{0}{1}", UrlBase, UrlListaSenador));

            // Tranforma a resposta string em objeto
            JObject respostaObjeto = JObject.Parse(resposta);

            //Navega nos nós do objeto Json e transforma em lista
            IList<JToken> parlamentares = respostaObjeto["ListaParlamentarEmExercicio"]["Parlamentares"]["Parlamentar"].Children()["IdentificacaoParlamentar"].ToList();

            // Serializa os objetos do Json para as classes do modelo no .Net
            IList<Senador> senadores = new List<Senador>();
            foreach (JToken parlamentar in parlamentares)
            {
                Senador sen = parlamentar.ToObject<Senador>();
                senadores.Add(sen);
            }

            return senadores.ToList<Senador>();
        }

        public static Senador ObterSenador(string id)
        {
            // Pega o Json do Webservice
            WebClient webClient = new WebClient();
            webClient.Headers[HttpRequestHeader.Accept] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            string resposta = webClient.DownloadString(string.Format("{0}{1}", UrlBase, string.Format(UrlObterSenador, id)));

            // Tranforma a resposta string em objeto
            JObject respostaObjeto = JObject.Parse(resposta);

            //Navega nos nós do objeto Json e transforma em lista
            JToken parlamentar = respostaObjeto["DetalheParlamentar"]["Parlamentar"]["IdentificacaoParlamentar"];

            // Serializa os objetos do Json para as classes do modelo no .Net
            Senador senador = new Senador();
            senador = parlamentar.ToObject<Senador>();
            
            return senador;
        }
    }
}
