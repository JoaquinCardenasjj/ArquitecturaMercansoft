using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.ModeloDatos
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
    }
}
