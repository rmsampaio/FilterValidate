using Newtonsoft.Json;
using System.Collections.Generic;

namespace FilterValidate.Models
{
    public class MensagemErro
    {
        public MensagemErro()
        {
            Erros = new List<Erro>();
        }
        [JsonProperty("erros")]
        public List<Erro> Erros { get; set; }
    }
}
