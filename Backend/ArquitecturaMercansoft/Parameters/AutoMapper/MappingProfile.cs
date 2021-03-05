using AutoMapper;
using Transversal.DTOS;
using System;
using System.Collections.Generic;
using System.Text;
using Transversal.Entities;

namespace Transversal.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cliente, ClienteDTO>();

            CreateMap<ClienteDTO, Cliente>();
            CreateMap<Cliente, Cliente>();
            // Se pueden agregar cualquier numero de maps
        }

    }
}
