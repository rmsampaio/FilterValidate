using System.Collections.Generic;

namespace FilterValidate.Serialization.Templates
{
    internal class TemplateComArrayComPropriedadesEmIngles : Template
    {
        protected override Dictionary<string, string> MapeamentoPropriedades => new Dictionary<string, string>
        {
            {"codigo", "code"},
            {"mensagem", "message"}
        };
    }
}
