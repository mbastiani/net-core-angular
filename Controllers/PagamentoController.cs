using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreAngular.Models;

namespace NetCoreAngular.Controllers
{
    [ApiController]
    [Route("pagamentos")]
    public class PagamentoController : ControllerBase
    {

        private readonly List<PagamentoModel> _pagamentos = new List<PagamentoModel>
            {
                new PagamentoModel(1, "MARCIO L L FREITAS", "5180071883097026", "09/2022", "933"),
                new PagamentoModel(2, "GABRIELA S A ALMADA", "5313032720537343", "04/2021", "156"),
                new PagamentoModel(3, "NINA P A MORAES", "5101217503009018", "02/2021", "847"),
                new PagamentoModel(4, "RAFAELA D GOMES", "5356531335075852", "12/2021", "447"),
                new PagamentoModel(5, "VICTOR E CRUZ", "5137007258974930", "01/2022", "828")
            };


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_pagamentos);
        }
    }
}
