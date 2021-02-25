using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Cliente
{
    public interface IClienteBI
    {
        public string ConsultarCliente();
        public bool RegistrarCliente(string Nombre, int Cedula);
    }
}
