using System;
using System.Collections.Generic;

namespace CollelDal.models;

public partial class Payment
{
    public DateTime DateOfPay { get; set; }

    public decimal TotalPayment { get; set; }

    public string? Note { get; set; }

    public int Code { get; set; }

    public string IdAvrech { get; set; } = null!;

    public virtual Avrech IdAvrechNavigation { get; set; } = null!;
}
