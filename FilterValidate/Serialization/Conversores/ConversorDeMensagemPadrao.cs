using FilterValidate.Models;
using FilterValidate.Resources;

namespace FilterValidate.Serialization.Conversores
{
    internal class ConversorDeMensagemPadrao : ConversorDeMensagem
    {
        public ConversorDeMensagemPadrao(string mensagem)
            : base(mensagem)
        {
        }

        public override MensagemErro Converter()
        {
            try
            {
                return ConverterObjeto<MensagemErro>();
            }
            catch
            {
                return new MensagemErro
                {
                    Erros = { new Erro { Codigo = "199", Mensagem = MensagensPadrao._199 } }
                };
            }
        }
    }
}
