using FilterValidate.Models;
using FilterValidate.Resources;
using FilterValidate.Serialization.Templates;

namespace FilterValidate.Serialization.Conversores
{
    public class ConversorDeMensagemComArrayComNomeErro : ConversorDeMensagem
    {
        public ConversorDeMensagemComArrayComNomeErro(string mensagem)
            : base(mensagem)
        {
            ContractResolver = new TemplateComArrayComONomeErroEComPropriedadesEmIngles();
        }

        public override MensagemErro Converter()
        {
            try
            {
                return ConverterObjetoComTemplate<MensagemErro>(this);
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
