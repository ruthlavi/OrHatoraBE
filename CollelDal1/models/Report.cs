using System;
using System.Collections.Generic;

namespace CollelDal.models;

public partial class Report
{
    public int Code { get; set; }

    public DateTime UpdateDate { get; set; }

    public decimal SumHours { get; set; }

    public string? Note { get; set; }

    public string IdAvrech { get; set; } = null!;

    public virtual Avrech IdAvrechNavigation { get; set; } = null!;
}
