using Business.SeguridadBI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Transversal.DTOS.Seguridad;

namespace Seguridad.Filters
{
    public class SecurityTokenFilter : Attribute, IActionFilter
    {
        private readonly ISeguridadBI _seguridad;
        public SecurityTokenFilter()
        {
        }
        public SecurityTokenFilter(ISeguridadBI seguridad)
        {
            _seguridad = seguridad;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("Leer token y verificar seguridad");
            var result = 0;

            if (result == 1)
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}
