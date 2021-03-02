using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transversal.DTOS;

namespace DataAccess.ClienteDAL
{
    public interface IClienteDAL
    {
        public List<ClienteDTO> ConsultarCliente();
        public string RegistrarCliente(ClienteDTO input);
        public string EditarCliente(ClienteDTO input);
        public string EliminarCliente(int idCliente);
    }
}
