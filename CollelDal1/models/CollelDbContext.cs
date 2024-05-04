using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CollelDal.models;

public partial class CollelDbContext : DbContext
{
    public CollelDbContext()
    {
    }

    public CollelDbContext(DbContextOptions<CollelDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Avrech> Avreches { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<StudyGroup> StudyGroups { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-ROECGEC\\SQLEXPRESS;Database=CollelDb;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Avrech>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Basic_de__3214EC078C8495F5");

            entity.ToTable("Avrech");

            entity.Property(e => e.Id)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AccountNum).HasColumnName("Account_Num");
            entity.Property(e => e.BankNum).HasColumnName("Bank_Num");
            entity.Property(e => e.BranchNum).HasColumnName("Branch_Num");
            entity.Property(e => e.DateOfReg)
                .HasColumnType("date")
                .HasColumnName("Date_of_Reg");
            entity.Property(e => e.FullName)
                .HasMaxLength(30)
                .HasColumnName("Full_Name");
            entity.Property(e => e.PartOfPayment).HasColumnName("Part_of_Payment");
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StatusReg).HasColumnName("Status_Reg");
            entity.Property(e => e.StudyGroup).HasColumnName("Study_Group");

            entity.HasOne(d => d.StudyGroupNavigation).WithMany(p => p.Avreches)
                .HasForeignKey(d => d.StudyGroup)
                .HasConstraintName("avrch_stdyGrp_fk");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Payments__A25C5AA6B72EBDAB");

            entity.Property(e => e.DateOfPay)
                .HasColumnType("date")
                .HasColumnName("Date_of_Pay");
            entity.Property(e => e.IdAvrech)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Id_Avrech");
            entity.Property(e => e.Note).HasMaxLength(120);
            entity.Property(e => e.TotalPayment)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("Total_Payment");

            entity.HasOne(d => d.IdAvrechNavigation).WithMany(p => p.Payments)
                .HasForeignKey(d => d.IdAvrech)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("idA");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Reports__A25C5AA63FBAFC91");

            entity.Property(e => e.IdAvrech)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Id_Avrech");
            entity.Property(e => e.Note).HasMaxLength(100);
            entity.Property(e => e.SumHours)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("Sum_Hours");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("Update_Date");

            entity.HasOne(d => d.IdAvrechNavigation).WithMany(p => p.Reports)
                .HasForeignKey(d => d.IdAvrech)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Idavrech");
        });

        modelBuilder.Entity<StudyGroup>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Study_Gr__A25C5AA654304025");

            entity.ToTable("Study_Group");

            entity.Property(e => e.GroupName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Group_Name");
            entity.Property(e => e.PayPerHour).HasColumnName("Pay_per_Hour");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
