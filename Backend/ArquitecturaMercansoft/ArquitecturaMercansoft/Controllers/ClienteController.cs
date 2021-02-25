
using AutoMapper;
using Business.ClienteBI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parameters.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArquitecturaMercansoft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
        public string ConsultarCliente()
        {
            var cliente = new DataAccess.Entities.Cliente
            {
                IdCliente = 1,
                Activo = false,
                Eliminado = true,
                Identificacion = "349324",
                Nombre = "Prueba",
                TipoIdentificacion = 1
            };

            var model = _mapper.Map<ClienteDTO>(cliente);

            var model2 = _mapper.Map<DataAccess.Entities.Cliente>(model);
            return this._clienteBi.ConsultarCliente();
        }
        [HttpPost]
        [Route("registrar")]
        public bool ConsultarCliente(string Nombre, string Cedula)
        {
            return this._clienteBi.RegistrarCliente(Nombre, Cedula);
        }
    }
}
