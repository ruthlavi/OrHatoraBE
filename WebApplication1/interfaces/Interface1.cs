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
        Avrech? getStudentById(string id);
        bool reportHours(Report r);
        bool registration(Avrech a);
        List<Payment> getPaymentsHistory(string id);



    }
}
