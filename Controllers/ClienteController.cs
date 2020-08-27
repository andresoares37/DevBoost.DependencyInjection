using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Application.Domain;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevBoost.DepedencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _cliente;

        public ClienteController(IClienteService cliente)
        {
            _cliente = cliente;
        }
        
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Cliente), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(Cliente), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(Cliente), (int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType(typeof(Cliente), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(Cliente), (int)HttpStatusCode.InternalServerError)]
        public ActionResult GetCliente()
        {
            var clientes = _cliente.Get();
            return Ok(clientes);
        }

        
        
        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Cliente), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(Cliente), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(Cliente), (int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType(typeof(Cliente), (int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType(typeof(Cliente), (int)HttpStatusCode.InternalServerError)]
        public ActionResult Post(Cliente cliente)
        {
            _cliente.Add(cliente);
            return Ok(cliente);
        }
    }
}
