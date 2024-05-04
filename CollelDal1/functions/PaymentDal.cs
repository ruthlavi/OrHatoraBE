using CollelDal.interfaces;
using CollelDal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollelDal.functions
{
    public class PaymentDal:IpaymentDal
    {
        //create variable type Context class 
        CollelDbContext collelDb;
        public PaymentDal(CollelDbContext collelDb) 
        {
            this.collelDb = collelDb;

        }

        //return all a preve payments (per avrech)
        public List<Payment> getPaymentsHistory(string id)
        {
            return collelDb.Payments.Where(p => p.IdAvrech == id).ToList();
        }



    }
}
