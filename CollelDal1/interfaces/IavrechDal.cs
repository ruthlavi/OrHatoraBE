using CollelDal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollelDal.interfaces
{
    public interface IavrechDal
    {
        //return avrech  by Id (if exist and just if status not 0 or null) 
        Avrech? GetById(string id);

        //delete avrech from db
        public bool Delete(Avrech a);

        //check register status
        public int CheckStatusReg(string id);

        //insert new avrech to the system.
        Avrech? AddReg(Avrech a);

        //aproves new register
        public bool AproveReg(Avrech avr);

        //get list of all avreches
        public List<Avrech> GetAll();

      


    }
}
