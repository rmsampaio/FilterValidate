using FluentValidation;
using System;

namespace FilterValidate.Serialization.Conversores
{
    public static class ConversorDeMensagemFactory
    {
        public static ConversorDeMensagem ObterConversor(Exception exception)
        {
            if (exception.Message.Contains("message") && exception.Message.Contains("code") && exception.Message.Contains("errors"))
                return new ConversorDeMensagemComArrayComNomeErro(exception.Message);

            if (exception.Message.Contains("message") && exception.Message.Contains("code") && !exception.Message.Contains("errors"))
                return new ConversorDeMensagemComArrayComPropriedadesEmIngles(exception.Message);

            if (exception.Message.Contains("mensagem") && exception.Message.Contains("codigo") && exception.Message.Contains("erros"))
                return new ConversorDeMensagemPadrao(exception.Message);
            if (exception is ValidationException)
                return new ConversorDeMensagemFLuentValidation(exception as ValidationException);

            return new ConversorDeMensagem199();
        }
    }
}
