using Transversal.Entities;
using DataAccess.ModeloDatos;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClienteDAL
{
    public class ClienteDAL : IClienteDAL
    {
        protected arquitecturamercansoft2Context _dbContext;
        public ClienteDAL(arquitecturamercansoft2Context dbContext)
        {
            this._dbContext = dbContext;
            //this._dbContext = new arquitecturamercansoftContextCodeFirst();
        }

        public string ConsultarCliente()
        {
            throw new NotImplementedException();
        }

        public bool RegistrarCliente(string Nombre, string Cedula)
        {
            this._dbContext.Clientes.Add(new ModeloDatos.Cliente
            {
                Identificacion = Cedula,
                Nombre = Nombre,
                TipoIdentificacion = "CC",
            });

            if (this._dbContext.SaveChanges() > 0)
            {
                return true;
            }

            return false;
        }
    }
}
