using Transversal.Entities;
using DataAccess.ModeloDatos;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transversal.DTOS;
using DataAccess.ModeloDatosCodeFirst;
using AutoMapper;

namespace DataAccess.ClienteDAL
{
    public class ClienteDAL : IClienteDAL
    {
        protected arquitecturamercansoft2Context _dbContext;
        protected ArquitecturaMercansoftContext _dbContextCodeFirst;
        private readonly IMapper _mapper;
        public ClienteDAL(arquitecturamercansoft2Context dbContext, ArquitecturaMercansoftContext dbContextCodeFirst, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._dbContextCodeFirst = dbContextCodeFirst;
            _mapper = mapper;
        }

        public List<ClienteDTO> ConsultarCliente()
        {
            List<ClienteDTO> listaDto = new List<ClienteDTO>();
            var listaClienteEntitie = this._dbContextCodeFirst.Clientes.ToList();
            listaClienteEntitie.ForEach(d => this.ConvertListaCliente(listaDto, d));
            return listaDto;
        }
        public List<ClienteDTO> ConvertListaCliente(List<ClienteDTO> listaDTO, Cliente cliente)
        {
            listaDTO.Add(_mapper.Map<ClienteDTO>(cliente));
            return listaDTO;
        }
        public string EditarCliente(ClienteDTO input)
        {
            var cliente = _mapper.Map<Cliente>(input);
            this._dbContextCodeFirst.Clientes.Update(cliente);
            this._dbContextCodeFirst.SaveChanges();
            return cliente.IdCliente.ToString();
        }

        public string EliminarCliente(int idCliente)
        {
            var cliente = this._dbContextCodeFirst.Clientes.Find(idCliente);
            cliente.Eliminado = true;
            // this._dbContextCodeFirst.Clientes.Remove(cliente);
            this._dbContextCodeFirst.Clientes.Update(cliente);
            this._dbContextCodeFirst.SaveChanges();
            return cliente.IdCliente.ToString();
        }

        public string RegistrarCliente(ClienteDTO input)
        {
            var cliente = _mapper.Map<Cliente>(input);
            this._dbContextCodeFirst.Clientes.Add(cliente);
            this._dbContextCodeFirst.SaveChanges();
            return cliente.IdCliente.ToString();
        }
    }
}
