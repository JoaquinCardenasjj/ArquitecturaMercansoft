
using DataAccess.ClienteDAL;
using Transversal.Logger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transversal.DTOS;
using Transversal.Transversal;

namespace Business.ClienteBI
{
    public class ClienteBI : IClienteBI
    {
        protected IClienteDAL _clienteDal;
        protected IClienteDAL _clienteDal2;
        public ClienteBI(IClienteDAL clienteDAL)
        {
            this._clienteDal = clienteDAL;
        }

        public Response<List<ClienteDTO>> ConsultarCliente(Response<List<ClienteDTO>> response)
        {
            try
            {
                response.ObjetoResultado = this._clienteDal.ConsultarCliente();
                response.Exitoso = true;
                return response;
            }
            catch (Exception e)
            {
                response.Mensaje = e.Message;
                response.Exitoso = false;
                response.ObjetoResultado = new List<ClienteDTO>();
                FileLogger.Logger(e);
            }

            return response;
        }

        public RegisterResponse EditarCliente(ClienteDTO input, RegisterResponse response)
        {
            try
            {
                response.IdResultado = this._clienteDal.EditarCliente(input);
                response.Exitoso = true;
                return response;
            }
            catch (Exception e)
            {
                response.Mensaje = e.Message;
                response.Exitoso = false;
                response.IdResultado = null;
                FileLogger.Logger(e);
            }

            return response;
        }

        public RegisterResponse EliminarCliente(int idCliente, RegisterResponse response)
        {
            try
            {
                response.IdResultado = this._clienteDal.EliminarCliente(idCliente);
                response.Exitoso = true;
                return response;
            }
            catch (Exception e)
            {
                response.Mensaje = e.Message;
                response.Exitoso = false;
                response.IdResultado = null;
                FileLogger.Logger(e);
            }

            return response;
        }

        public RegisterResponse RegistrarCliente(ClienteDTO input, RegisterResponse response)
        {            
            try
            {                
                response.IdResultado = this._clienteDal.RegistrarCliente(input);
                response.Exitoso = true;
                return response;
            }
            catch (Exception e)
            {
                response.Mensaje = e.Message;
                response.Exitoso = false;
                response.IdResultado = null;
                FileLogger.Logger(e);
            }

            return response;
        }


    }
}
