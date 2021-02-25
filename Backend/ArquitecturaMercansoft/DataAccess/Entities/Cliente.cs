using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Cliente
    {
        public Cliente()
        {

        }
        public int IdCliente{ get; set; }
        public string Nombre { get; set; }
        public int TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public bool Activo { get; set; }
        public bool Eliminado { get; set; }

        public ICollection<Factura> Facturas { get; } = new List<Factura>();
    }
}
