using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Producto
    {
        public Producto()
        {
        }
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public bool Activo { get; set; }
        public bool Eliminado { get; set; }
        public ICollection<Orden> Ordenes { get; } = new List<Orden>();
    }
}
