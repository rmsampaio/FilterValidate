using FilterValidate.Models;
using FilterValidate.Resources;
using FilterValidate.Serialization.Templates;
using System.Collections.Generic;

namespace FilterValidate.Serialization.Conversores
{
    public class ConversorDeMensagemComArrayComPropriedadesEmIngles : ConversorDeMensagem
    {
        public ConversorDeMensagemComArrayComPropriedadesEmIngles(string mensagem)
            : base(mensagem)
        {
            ContractResolver = new TemplateComArrayComONomeErroEComPropriedadesEmIngles();
        }

        public override MensagemErro Converter()
        {
            try
            {
                var erros = ConverterObjetoComTemplate<List<Erro>>(this);
                return new MensagemErro { Erros = erros };
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
