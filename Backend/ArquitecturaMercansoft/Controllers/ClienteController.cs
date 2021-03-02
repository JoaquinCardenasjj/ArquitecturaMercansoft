
using AutoMapper;
using Business.ClienteBI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Transversal.DTOS;
using Seguridad.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transversal.Entities;
using Transversal.Transversal;

namespace ArquitecturaMercansoft.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [SecurityTokenFilter]
    public class ClienteController : ControllerBase
    {
        IClienteBI _clienteBi;
        private readonly IMapper _mapper;
        public ClienteController(IClienteBI clienteBI, IMapper mapper)
        {
            _clienteBi = clienteBI;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("consultar")]
        public IActionResult ConsultarCliente()
        {
            Response<List<ClienteDTO>> response = new Response<List<ClienteDTO>>();
            response = this._clienteBi.ConsultarCliente(response);
            return Ok(response);
        }
        [HttpPost]
        [Route("registrar")]
        public IActionResult RegistrarCliente(ClienteDTO input)
        {
            RegisterResponse response = new RegisterResponse();
            this._clienteBi.RegistrarCliente(input, response);
            return Ok(response);
        }
        [HttpPut]
        [Route("editar")]
        public IActionResult EditarCliente(ClienteDTO input)
        {

            RegisterResponse response = new RegisterResponse();
            this._clienteBi.EditarCliente(input, response);
            return Ok(response);
        }
        [HttpPost]
        [Route("eliminar")]
        public IActionResult EliminarCliente(int idCliente)
        {
            RegisterResponse response = new RegisterResponse();
            this._clienteBi.EliminarCliente(idCliente, response);
            return Ok(response);
        }
    }
}
