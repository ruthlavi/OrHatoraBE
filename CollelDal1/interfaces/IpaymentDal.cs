﻿using CollelDal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollelDal.interfaces
{
    public interface IpaymentDal
    {
        List<Payment> getPaymentsHistory(string id);

    }
}
