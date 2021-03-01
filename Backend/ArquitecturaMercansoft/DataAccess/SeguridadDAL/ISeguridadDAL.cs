using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transversal.DTOS.Seguridad;

namespace DataAccess.SeguridadDAL
{
    public interface ISeguridadDAL
    {
        public bool VerificarDatos(LoginDTO input);
    }
}
