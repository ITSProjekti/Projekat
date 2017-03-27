using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ITS_Pravi_Projekat.Dtos;
using ITS_Pravi_Projekat.Models;
namespace ITS_Pravi_Projekat.App_Start 
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Osoba, OsobaDto>();
            Mapper.CreateMap<OsobaDto,Osoba >();

        }
    }
}