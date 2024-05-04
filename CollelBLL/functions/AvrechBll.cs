using AutoMapper;
using CollelBll.DTO;
using CollelBll.DTO.modelsDto;
using CollelBll.interfaces;
using CollelDal.functions;
using CollelDal.interfaces;
using CollelDal.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CollelBll.functions
{
    public class AvrechBll:IavrechBll
    {
        IMapper mapper;
        IavrechDal avrDal;
        public AvrechBll(IavrechDal avrDal)
        {
            this.avrDal= avrDal;
            //Initialize the conversion variable of this class
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DTO.Mapper>();
            });
            mapper = config.CreateMapper();
        }

        public AvrechDto? GetById(string id)
        {
            if (avrDal.GetById(id) != null&&avrDal.CheckStatusReg(id)==1)
            {
                return mapper.Map<Avrech, AvrechDto>(avrDal.GetById(id));
            }
            return null;
        }

        public Avrech? AddReg(AvrechDto a)
        {
            if (avrDal.GetById(a.Id) == null)
            {
                return avrDal.AddReg(mapper.Map<AvrechDto, Avrech>(a));
            }
            else
                return null;
        }

        public bool AproveReg(Avrech a)
        {
            if (avrDal.GetById(a.Id) != null&&avrDal.CheckStatusReg(a.Id)!=1)
            {
                return avrDal.AproveReg(a);
            }
            else { return false; }
        }

        public List<AvrechDto> GetAll()
        {
            List<Avrech> avreches=avrDal.GetAll();
            return mapper.Map<avreches, List<AvrechDto>>;

        }







    }
}
