using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Orden
    {
        public Orden()
        {
        }
        public int FacturaId{ get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public double ValorTotal { get; set; }
        public bool Activo { get; set; }
        public bool Eliminado { get; set; }
        public Factura Factura{ get; set; }
        public Producto Producto { get; set; }
    }
}
