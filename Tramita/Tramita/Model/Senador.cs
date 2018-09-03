using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tramita.Model
{

    [JsonObject("IdentificacaoParlamentar")]
    public class Senador
    {
        [JsonProperty(PropertyName = "CodigoParlamentar")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "NomeParlamentar")]
        public string Nome { get; set; }
        [JsonProperty(PropertyName = "NomeCompletoParlamentar")]
        public string NomeCompleto { get; set; }
        [JsonProperty(PropertyName = "SexoParlamentar")]
        public string Sexo { get; set; }
        [JsonProperty(PropertyName = "UrlFotoParlamentar")]
        public string UrlFotoParlamentar { get; set; }
        [JsonProperty(PropertyName = "UrlPaginaParlamentar")]
        public string UrlPaginaParlamentar { get; set; }
        [JsonProperty(PropertyName = "EmailParlamentar")]
        public string EmailParlamentar { get; set; }
        [JsonProperty(PropertyName = "SiglaPartidoParlamentar")]
        public string SiglaPartidoParlamentar { get; set; }
        [JsonProperty(PropertyName = "UfParlamentar")]
        public string SiglaUfParlamentar { get; set; }

        public Senador()
        {

        }
    }
}
