using System;
using System.Collections.Generic;

namespace CollelBll.DTO.modelsDto;

public partial class PaymentDto
{
    public DateTime DateOfPay { get; set; }

    public decimal TotalPayment { get; set; }

    public string? Note { get; set; }

    public int Code { get; set; }

    public string IdAvrech { get; set; } = null!;

    public virtual AvrechDto IdAvrechNavigation { get; set; } = null!;
}
