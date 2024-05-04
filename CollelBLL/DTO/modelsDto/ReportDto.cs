using System;
using System.Collections.Generic;

namespace CollelBll.DTO.modelsDto;

public partial class ReportDto
{
    public int Code { get; set; }

    public DateTime UpdateDate { get; set; }

    public decimal SumHours { get; set; }

    public string? Note { get; set; }

    public string IdAvrech { get; set; } = null!;

    public virtual AvrechDto IdAvrechNavigation { get; set; } = null!;
}
