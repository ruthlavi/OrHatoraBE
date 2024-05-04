using CollelDal.models;
using CollelDal.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CollelDal.functions
{
    public class AvrechDal : IavrechDal
    {
        //create variable type Context class 
        CollelDbContext collelDb;

        //constractor
        public AvrechDal(CollelDbContext collelDb)
        {
            Console.WriteLine("constractor");
            this.collelDb = collelDb;
        }

        public Avrech? GetById(string id)
        {
            Avrech? avr = collelDb.Avreches.FirstOrDefault(a => a.Id == id);
            if (avr != null) 
            {
                return avr;
            }
            else return null;
        }

        public List<Avrech> GetAll()
        {
            return collelDb.Avreches.ToList();
        }

        public bool Delete(Avrech a)
        {
            try {
                collelDb.Avreches.Remove(a);
                collelDb.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public Avrech? AddReg(Avrech avr)
        {
            try {
                collelDb.Avreches.Add(avr);
                collelDb.SaveChanges();
                return avr;
            }
            catch
            {
                return null;
            }
        }

        public bool AproveReg(Avrech avr)
        {
            try {
                avr.StatusReg = 1;
                collelDb.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public int CheckStatusReg(string id)
        {
            Avrech avr = collelDb.Avreches.FirstOrDefault(a => a.Id == id);
            int status;
            if (avr.StatusReg == null || avr.StatusReg == 0) status=0;
            else status=1;
            return status;
        }
       











    }
}

