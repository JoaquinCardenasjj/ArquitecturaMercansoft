using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Factura
    {
        public Factura()
        {
        }
        public int IdFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public int ClienteId { get; set; }
        public bool Activo { get; set; }
        public bool Eliminado { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<Orden> Ordenes { get; } = new List<Orden>();
    }
}
