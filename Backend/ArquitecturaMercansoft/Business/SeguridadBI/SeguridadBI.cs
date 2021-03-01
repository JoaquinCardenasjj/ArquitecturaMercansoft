using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transversal.DTOS.Seguridad;

namespace Business.SeguridadBI
{
    public class SeguridadBI : ISeguridadBI
    {
        public bool VerificarDatos(LoginDTO input)
        {
            if (String.Equals(input.UserName, "joaquin"))
            {
                return true;
            }

            return false;
        }
    }
}
