using AutoMapper;
using CollelBll.DTO.modelsDto;
using CollelDal.functions;
using CollelDal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollelBll.DTO
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            //casting from avrech to avrechDto and return;
            CreateMap<Avrech, AvrechDto>().ForMember
                (d => d.Phone, opt => opt.MapFrom(src => 0 + src.Phone));
            CreateMap<AvrechDto, Avrech>();
            //casting from list type arech to list type avrechDto and return;
            CreateMap<List<Avrech>, List<AvrechDto>>();
            CreateMap<List<AvrechDto>,List<Avrech>>();



        } 



    }
}
