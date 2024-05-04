using System;
using System.Collections.Generic;

namespace CollelDal.models;

public partial class Avrech
{
    public string Id { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? Phone { get; set; }

    public int? BankNum { get; set; }

    public int? BranchNum { get; set; }

    public int? AccountNum { get; set; }

    public double? PartOfPayment { get; set; }

    public DateTime? DateOfReg { get; set; }

    public int? StudyGroup { get; set; }

    public int? StatusReg { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual StudyGroup? StudyGroupNavigation { get; set; }
}
