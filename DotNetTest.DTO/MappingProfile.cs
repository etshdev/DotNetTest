using AutoMapper;
using DotNetTest.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest.DTO
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap <Driver,DriverDTO > ().ReverseMap();

        }
    }
}
