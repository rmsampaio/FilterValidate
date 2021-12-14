using FilterValidate.Serialization.Conversores;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace FilterValidate.Filters
{
    public class ExceptionFilterValidationAttribute : Attribute, IExceptionFilter
    {
        public ExceptionFilterValidationAttribute()
        {

        }
        public void OnException(ExceptionContext context)
        {
            var conversor = ConversorDeMensagemFactory.ObterConversor(context.Exception);
            var mensagem = conversor.Converter();
            context.Result = new BadRequestObjectResult(mensagem);
        }
    }
}
