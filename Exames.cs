using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using RES.Integracao.Exames.Function.Models;

namespace RES.Integracao.Exames.Function
{
    public class Exames
    {
        private readonly ILogger<Exames> _logger;

        public Exames(ILogger<Exames> log)
        {
            _logger = log;
        }

        [FunctionName("Exames")]
        [OpenApiOperation(operationId: "Run", tags: new[] { "Integrar Exames com o RES" })]
        [OpenApiSecurity("function_key", SecuritySchemeType.ApiKey, Name = "code", In = OpenApiSecurityLocationType.Query)]
        [OpenApiRequestBody("application/json", typeof(Exame))]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.Created, contentType: "application/json", bodyType: typeof(string), Description = "{  message = Dados processados com sucesso }")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.BadRequest, contentType: "text", bodyType: typeof(string), Description = "Erro ao integrar Exames")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] string exames)
        {
            var dataAtual = new DateTime();
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");
            
            _logger.LogInformation("Request recebido às " + dataAtual.ToString());
            
            Random rnd = new Random();
            int id = rnd.Next(1, 1000);
            int statusCode = (int)HttpStatusCode.Created;

            return new ObjectResult(new { stauts_code = statusCode, id = id,  message = "Dados processados com sucesso" }) { StatusCode = statusCode };
        }
    }
}

