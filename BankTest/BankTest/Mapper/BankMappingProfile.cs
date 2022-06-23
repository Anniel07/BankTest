using AutoMapper;
using BankTest.DTO;
using BankTest.Models;
using BankTest.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankTest.Mapper
{
    public class BankMappingProfile : Profile
    {
        public BankMappingProfile() {
            CreateMap<Contact, ContactDto>()
                .ForMember(dest => dest.DateofBirth, 
                opt => opt.MapFrom(src => src.DateofBirth.ToString(Utility.formatter)))
                .ForMember(dest => dest.Age, 
                opt => opt.MapFrom(src => Utility.GetAge(src.DateofBirth)));
        }
    }
}
