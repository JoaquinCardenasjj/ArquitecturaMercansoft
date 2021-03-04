using ArquitecturaMercansoftUnitTest.ModeloDatosPrueba;
using AutoMapper;
using DataAccess.ClienteDAL;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transversal.AutoMapper;
using Transversal.DTOS;
using Xunit;

namespace ArquitecturaMercansoftUnitTest.ClienteTest
{
    public class ClienteDALTest : CommandTestBase
    {
        [Test]
        public void ConsultarClienteTest()
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = new Mapper(mapperConfig);
            var _clientedal = new ClienteDAL(_context, mapper);
            var result = _clientedal.ConsultarCliente().Count;

            Assert.AreEqual(3, result);
        }
        [Test]
        public void CrearClienteTest()
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = new Mapper(mapperConfig);
            var _clientedal = new ClienteDAL(_context, mapper);
            _clientedal.RegistrarCliente(new ClienteDTO
            {
                Identificacion = "378382",
                Activo = true,
                Eliminado = false,
                Nombre = "PRUEBA",
                IdCliente = 4,
                TipoIdentificacion = 3
            });

            Assert.AreEqual(4, _context.Clientes.AsNoTracking().ToList().Count);
        }

        [Test]
        public void ActualizarClienteTest()
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = new Mapper(mapperConfig);
            var _clientedal = new ClienteDAL(_context, mapper);
            
            var clienteEditado = new ClienteDTO
            {
                IdCliente = 1,
                Nombre = "Roberto",
                Identificacion = "123456",
                TipoIdentificacion = 2,
                Activo = false,
                Eliminado = true
            };
            _clientedal.EditarCliente(clienteEditado);

            var cliente = _context.Clientes
                                  .AsNoTracking()
                                  .FirstOrDefault(d => d.IdCliente == clienteEditado.IdCliente);
            Assert.AreEqual(clienteEditado.Nombre, cliente.Nombre);
        }
        [Test]
        public void EliminarClienteTest()
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = new Mapper(mapperConfig);
            var _clientedal = new ClienteDAL(_context, mapper);
            
            _clientedal.EliminarCliente(2);

            var cliente = _context.Clientes
                                  .AsNoTracking()
                                  .FirstOrDefault(d => d.IdCliente == 2);
            Assert.AreEqual(true, cliente.Eliminado);
        }
    }   
}
