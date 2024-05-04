using System;
using System.Collections.Generic;

namespace CollelBll.DTO.modelsDto;

public partial class AvrechDto
{
    public string Id { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? Phone { get; set; }

    public int? BankNum { get; set; }

    public int? BranchNum { get; set; }

    public int? AccountNum { get; set; }

    public DateTime? DateOfReg { get; set; }

    public int? StudyGroup { get; set; }

    public int? StatusReg { get; set; }

}
