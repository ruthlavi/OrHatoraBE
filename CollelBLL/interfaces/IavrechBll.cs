using CollelBll.DTO.modelsDto;
using CollelDal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollelDal.interfaces
{
    public interface IavrechBll
    {
        //check this student exist and return him in DTO
        public AvrechDto? GetById(string id);

        //get all students in dto type
        public List<AvrechDto> GetAll();

        //check if student id not exist and add this student
        public Avrech? AddReg(AvrechDto a);

        //check this avrech exist and not aprove and aprove him.
        public bool AproveReg(Avrech a);





    }
}
