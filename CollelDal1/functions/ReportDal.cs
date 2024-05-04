using CollelDal.interfaces;
using CollelDal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollelDal.functions
{
    public class ReportDal:IreportDal
    {
        CollelDbContext collelDb;

        public ReportDal(CollelDbContext collelDb)
        {
            this.collelDb = collelDb;
        }
        //insert student report of the current month
        public bool reportHours(Report r)
        {
            collelDb.Reports.Add(r);
            collelDb.SaveChanges();
            return true;
        }
    }
}
