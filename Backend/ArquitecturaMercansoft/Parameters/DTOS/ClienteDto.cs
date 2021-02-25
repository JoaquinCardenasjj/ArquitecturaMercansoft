using Parameters.Transversal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parameters.DTOS
{
    public class ClienteDTO : BaseOut
    {
        public ClienteDTO()
        {
        }
        
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public int TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public bool Activo { get; set; }
        public bool Eliminado { get; set; }
    }
}
