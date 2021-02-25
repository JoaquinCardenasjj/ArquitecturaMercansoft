
using DataAccess.ClienteDAL;
using Parameters.Logger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        public string ConsultarCliente()
        {
            try
            {
                _clienteDal2.ConsultarCliente();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"Excepcion: '{e}'");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Excepcion: '{e}'");
                FileLogger.Logger(e);
            }
           

            return Guid.NewGuid().ToString();
        }

        public bool RegistrarCliente(string Nombre, string Cedula)
        {
            return this._clienteDal.RegistrarCliente(Nombre, Cedula);
        }
    }
}
