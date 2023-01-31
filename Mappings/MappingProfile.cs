﻿using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}
