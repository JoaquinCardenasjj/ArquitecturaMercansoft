using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Cliente
{
    public class ClienteBI : IClienteBI
    {
        public string ConsultarCliente()
        {
            return Guid.NewGuid().ToString();
        }

        public bool RegistrarCliente(string Nombre, int Cedula)
        {
            if (String.IsNullOrEmpty(Nombre))
            {
                return false;
            }
            return true;
        }
    }
}
