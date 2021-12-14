using FilterValidate.Models;
using Newtonsoft.Json;

namespace FilterValidate.Serialization.Conversores
{
    public abstract class ConversorDeMensagem : JsonSerializerSettings
    {
        private readonly string _mensagem;
        public ConversorDeMensagem(string mensagem)
        {
            _mensagem = mensagem;
        }

        public abstract MensagemErro Converter();
        protected T ConverterObjeto<T>() where T : class
        {
            var entidadeRetorno = JsonConvert.DeserializeObject<T>(_mensagem);
            return entidadeRetorno;
        }

        protected T ConverterObjetoComTemplate<T>(JsonSerializerSettings jsonSerializerSettings) where T : class
        {
            var entidadeRetorno = JsonConvert.DeserializeObject<T>(_mensagem, jsonSerializerSettings);
            return entidadeRetorno;
        }

    }
}
