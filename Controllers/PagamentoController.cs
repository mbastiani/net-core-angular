using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreAngular.Models;

namespace NetCoreAngular.Controllers
{
    [ApiController]
    [Route("api/cartoes")]
    public class CartaoController : ControllerBase
    {

        private readonly List<CartaoModel> _cartoes = new List<CartaoModel>
            {
                new CartaoModel(1, "MARCIO L L FREITAS", "5180071883097026", "09/2022", "933"),
                new CartaoModel(2, "GABRIELA S A ALMADA", "5313032720537343", "04/2021", "156"),
                new CartaoModel(3, "NINA P A MORAES", "5101217503009018", "02/2021", "847"),
                new CartaoModel(4, "RAFAELA D GOMES", "5356531335075852", "12/2021", "447"),
                new CartaoModel(5, "VICTOR E CRUZ", "5137007258974930", "01/2022", "828")
            };


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_cartoes);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var cartao = _cartoes.Find(x => x.Id == id);

            if (cartao is null)
                return NotFound();

            _cartoes.Remove(cartao);

            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] CartaoModel args)
        {
            var cartao = _cartoes.Find(x => x.Id == id);

            if (cartao is null)
                return NotFound();

            cartao.AtualizarDados(args.NomeTitular, args.NumeroCartao, args.DataExpiracao, args.CVV);

            return NoContent();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CartaoModel args)
        {
            var lastId = _cartoes.Select(x => x.Id).Max();

            args.DefinirId(++lastId);

            _cartoes.Add(args);

            return Ok();
        }
    }
}
