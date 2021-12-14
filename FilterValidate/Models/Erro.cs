using Newtonsoft.Json;

namespace FilterValidate.Models
{
    public class Erro
    {
        [JsonProperty("codigo")]
        public string Codigo { get; set; }
        [JsonProperty("mensagem")]
        public string Mensagem { get; set; }
    }
}
