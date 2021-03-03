using ArquitecturaMercansoftUnitTest.ModeloDatosPrueba;
using AutoMapper;
using DataAccess.ClienteDAL;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArquitecturaMercansoftUnitTest.ClienteTest
{
    public class ClienteDALTest : CommandTestBase
    {
        private readonly IMapper _mapper;
        public ClienteDALTest(IMapper mapper)
        {            
            _mapper = mapper;
        }


        [Test]
        public void ConsultarClienteTest()
        {            
            var _clientedal = new ClienteDAL(_context, _mapper);
            var result = _clientedal.ConsultarCliente().Count;
            
            //Assert.AreEqual(4, count);
            // Arrange
            //var mediatorMock = new Mock<IMediator>();
            //var sut = new CrearEditarBienvenidaCommand.CrearEditarBienvenidaCommandHandler(_context);
            //// Act
            //var idBienvenida = sut.Handle(_command, CancellationToken.None);
            //// Assert
            //Assert.Equal(4, _context.Parametros.Count());
            ////mediatorMock.Verify(m => m.Publish(It.Is<UpsertPacienteNotification>(pc => pc.PacienteId == editPacienteId), It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}
