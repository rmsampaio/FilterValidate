using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace FilterValidate.Serialization.Templates
{
    public abstract class Template : DefaultContractResolver
    {
        protected abstract Dictionary<string, string> MapeamentoPropriedades { get; }

        protected override string ResolvePropertyName(string propertyName)
        {
            var resolved = MapeamentoPropriedades.TryGetValue(propertyName, out var resolvedName);
            return resolved ? resolvedName : ResolvePropertyName(propertyName);
        }

    }
}
