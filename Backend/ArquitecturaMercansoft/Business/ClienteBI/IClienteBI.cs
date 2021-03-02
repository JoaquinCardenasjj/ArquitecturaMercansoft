using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transversal.DTOS;
using Transversal.Transversal;

namespace Business.ClienteBI
{
    public interface IClienteBI
    {
        public Response<List<ClienteDTO>> ConsultarCliente(Response<List<ClienteDTO>> response);
        public RegisterResponse RegistrarCliente(ClienteDTO input, RegisterResponse response);
        public RegisterResponse EditarCliente(ClienteDTO input, RegisterResponse response);
        public RegisterResponse EliminarCliente(int idCliente, RegisterResponse response);
    }
}
