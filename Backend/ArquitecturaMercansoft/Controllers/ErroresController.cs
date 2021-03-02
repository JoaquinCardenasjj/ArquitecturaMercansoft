using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArquitecturaMercansoft.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErroresController : ControllerBase
    {
        [Route("error")]
        public IActionResult Error()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            return Problem(
                detail: context.Error.StackTrace,
                title: context.Error.Message);
        }
    }
}
