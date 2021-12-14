using FilterValidate.Models;
using FluentValidation;
using System.Linq;

namespace FilterValidate.Serialization.Conversores
{
    internal class ConversorDeMensagemFLuentValidation : ConversorDeMensagem
    {
        private readonly ValidationException _exception;
        public ConversorDeMensagemFLuentValidation(ValidationException exception)
            : base(string.Empty)
        {
            _exception = exception;
        }

        public override MensagemErro Converter()
        {
            var mensagemErro = new MensagemErro
            {
                Erros = _exception.Errors.Select(x => new Erro { Codigo = x.ErrorCode, Mensagem = x.ErrorMessage }).ToList()
            };
            return mensagemErro;
        }
    }
}
