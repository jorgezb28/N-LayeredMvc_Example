using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppService.Dto;
using AutoMapper;
using Domain.Entities;

namespace AppService
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Store, StoreDto>().ReverseMap();
            CreateMap<Employee, EmployeeDto>().ReverseMap();
        }
       
    }
}
