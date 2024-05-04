using System;
using System.Collections.Generic;

namespace CollelDal.models;

public partial class StudyGroup
{
    public int Code { get; set; }

    public string GroupName { get; set; } = null!;

    public int PayPerHour { get; set; }

    public virtual ICollection<Avrech> Avreches { get; set; } = new List<Avrech>();
}
