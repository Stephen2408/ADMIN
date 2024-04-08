using AutoMapper;
using CarManagement.Model;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagement.Utilites.Mapping
{
    public class MappingCar : Profile
    {
        public MappingCar()
        {
            CreateMap<CarDTO, Car>();
            CreateMap<Car, CarDTO>();
        }
    }
}
