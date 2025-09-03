using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MinhaAPIcore.Controllers
{
    [Route("api/[controller]")]
  
    public class ValuesController : MainController
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var valores = new string[] { "valor1", "valor2" };
            if (valores.Length < 5000)
                return CustomResponse();

            return CustomResponse(valores);
        }

        [HttpGet]
        public ActionResult ObterResutados()
        {
            var valores = new string[] { "valor1", "valor2" };
            if (valores.Length < 5000)
                return BadRequest();

            return Ok(valores);
        }


        [HttpGet("obter-valores")]
        public <IEnumerable<string> ObterValores()
        {
            var valores = new string[] { "valor1", "valor2" };
            if (valores.Length < 5000)
                return null;

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(typeof(Product), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post(Product product)
        {
            if (product.Id == 0) return BadRequest();

            return CreatedAtAction(actionName: nameof(Post), product);

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put([FromRoute] int id, [FromForm] Product value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete([FromQuery] int id)
        {
        }
    }

    [ApiController]
    public abstract class MainController :ControllerBase
        {

        protected ActionResult CustomResponse(object result = null)
        {
            if (OperacaoValida())
            {
                return Ok(value:new
                {
                    success = true,
                    data = result
                });
            });
            return BadRequest(error: new
            {
                success = false,
                errors = ObterErro()
            }  );
        }

        public bool OperacaoValida()
        {
            return true;
        }

        public string ObterErro()
        {
            return "Ocorreu um erro";
        }
    }

    public class Product
    {
        public int Id { get; set; }
    }
}