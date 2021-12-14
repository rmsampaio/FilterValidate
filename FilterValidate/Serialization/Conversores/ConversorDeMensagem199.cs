using FilterValidate.Models;
using FilterValidate.Resources;

namespace FilterValidate.Serialization.Conversores
{
    internal class ConversorDeMensagem199 : ConversorDeMensagem
    {
        public ConversorDeMensagem199()
            : base(string.Empty)
        {
        }

        public override MensagemErro Converter()
        {
            return new MensagemErro
            {
                Erros = { new Erro { Codigo = "199", Mensagem = MensagensPadrao._199 } }
            };
        }
    }
}
