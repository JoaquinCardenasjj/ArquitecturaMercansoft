using DataAccess.ModeloDatosCodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaMercansoftUnitTest.ModeloDatosPrueba
{
    public class CommandTestBase : IDisposable
    {
        protected readonly ArquitecturaMercansoftContext _context;

        public CommandTestBase()
        {
            _context = ArquitecturaMercansoftTestContextFactory.Create();
        }

        public void Dispose()
        {
            ArquitecturaMercansoftTestContextFactory.Destroy(_context);
        }
    }
}
