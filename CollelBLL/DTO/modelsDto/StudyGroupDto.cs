using System;
using System.Collections.Generic;

namespace CollelBll.DTO.modelsDto;

public partial class StudyGroupDto
{
    public int Code { get; set; }

    public string GroupName { get; set; } = null!;

    public int PayPerHour { get; set; }

    public virtual ICollection<AvrechDto> Avreches { get; set; } = new List<AvrechDto>();
}
