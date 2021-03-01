using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transversal.DTOS.Seguridad;

namespace Business.SeguridadBI
{
    public interface ISeguridadBI
    {
        public bool VerificarDatos(LoginDTO input);
    }
}
