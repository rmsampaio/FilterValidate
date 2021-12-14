using System.Collections.Generic;

namespace FilterValidate.Serialization.Templates
{
    internal class TemplateComArrayComONomeErroEComPropriedadesEmIngles : Template
    {
        protected override Dictionary<string, string> MapeamentoPropriedades => new Dictionary<string, string>
        {
            {"erros", "errors"},
            {"codigo", "code"},
            {"mensagem", "message"}
        };
    }
}
