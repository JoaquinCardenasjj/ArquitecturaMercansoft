using AutoMapper;
using Parameters.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parameters.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DataAccess.Entities.Cliente, ClienteDTO>();

            CreateMap<ClienteDTO, DataAccess.Entities.Cliente>();            
            // Se pueden agregar cualquier numero de maps
        }

    }
}
