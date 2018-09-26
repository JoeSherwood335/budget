using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace budget.Models
{
    public partial class BudgetMVCContext : DbContext
    {
        public BudgetMVCContext()
        {
        }

        public BudgetMVCContext(DbContextOptions<BudgetMVCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountCategories> AccountCategories { get; set; }
        public virtual DbSet<AccountGroups> AccountGroups { get; set; }
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<Companies> Companies { get; set; }
        public virtual DbSet<CostCenters> CostCenters { get; set; }
        public virtual DbSet<Dashboard> Dashboard { get; set; }
        public virtual DbSet<Divisions> Divisions { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<FringesCalc> FringesCalc { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Months> Months { get; set; }
        public virtual DbSet<Rectypes> Rectypes { get; set; }
        public virtual DbSet<TemplateDetails> TemplateDetails { get; set; }
        public virtual DbSet<Templates> Templates { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        public virtual DbQuery<vArchiveDataGrid> vArchiveDataGrid { get; set;}

        // Unable to generate entity type for table 'cfg.CurrentBudgetYear'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=apollo.vgs.vgsjob.net;Database=BudgetMVC;User ID=sa;Password=IL0veM@rvelM0vies;Application Name=BudgetApp");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountCategories>(entity =>
            {
                entity.Property(e => e.AccountCategory).IsUnicode(false);

                entity.Property(e => e.AccountCategoryDesc).IsUnicode(false);
            });

            modelBuilder.Entity<AccountGroups>(entity =>
            {
                entity.Property(e => e.AccountGroup).IsUnicode(false);

                entity.Property(e => e.AccountGroupDesc).IsUnicode(false);
            });

            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.Property(e => e.AccountDesc).IsUnicode(false);

                entity.HasOne(d => d.AccountCategoryNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.AccountCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accounts_AccountCategories");

                entity.HasOne(d => d.AccountGroupNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.AccountGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accounts_AccountGroups");
            });

            modelBuilder.Entity<Companies>(entity =>
            {
                entity.Property(e => e.CompanyDesc).IsUnicode(false);
            });

            modelBuilder.Entity<CostCenters>(entity =>
            {
                entity.Property(e => e.CostCenter).IsUnicode(false);

                entity.Property(e => e.CostCenterName).IsUnicode(false);
            });

            modelBuilder.Entity<Dashboard>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<Divisions>(entity =>
            {
                entity.Property(e => e.Division).IsUnicode(false);

                entity.Property(e => e.DivisionDesc).IsUnicode(false);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.Property(e => e.Acct).IsUnicode(false);

                entity.Property(e => e.AdpCompany).IsUnicode(false);

                entity.Property(e => e.Cc).IsUnicode(false);

                entity.Property(e => e.CompanyCode).IsUnicode(false);

                entity.Property(e => e.FileAs).IsUnicode(false);

                entity.Property(e => e.Firstname).IsUnicode(false);

                entity.Property(e => e.H1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.H1p).HasDefaultValueSql("((100))");

                entity.Property(e => e.H2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.H2p).HasDefaultValueSql("((0))");

                entity.Property(e => e.H3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.H3p).HasDefaultValueSql("((0))");

                entity.Property(e => e.H4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.H4p).HasDefaultValueSql("((0))");

                entity.Property(e => e.H5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.H5p).HasDefaultValueSql("((0))");

                entity.Property(e => e.H6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.H6p).HasDefaultValueSql("((0))");

                entity.Property(e => e.InputSource).IsUnicode(false);

                entity.Property(e => e.JobDesc).IsUnicode(false);

                entity.Property(e => e.Lastname).IsUnicode(false);

                entity.Property(e => e.Newemploye).HasDefaultValueSql("((-1))");

                entity.Property(e => e.R2kname).IsUnicode(false);

                entity.Property(e => e.Splitcostc).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ssn).IsUnicode(false);

                entity.Property(e => e.Total).HasDefaultValueSql("((0))");

                entity.Property(e => e.Totalnew).HasDefaultValueSql("((0))");

                entity.Property(e => e.TxtAdmin).IsUnicode(false);

                entity.Property(e => e.Wc).IsUnicode(false);
            });

            modelBuilder.Entity<FringesCalc>(entity =>
            {
                entity.Property(e => e.Account).IsUnicode(false);

                entity.Property(e => e.BaseAccount).IsUnicode(false);

                entity.Property(e => e.Ccexception).IsUnicode(false);

                entity.Property(e => e.CompExceptions).IsUnicode(false);

                entity.Property(e => e.FName).IsUnicode(false);

                entity.Property(e => e.FormulaM1).IsUnicode(false);

                entity.Property(e => e.FormulaM10).IsUnicode(false);

                entity.Property(e => e.FormulaM11).IsUnicode(false);

                entity.Property(e => e.FormulaM12).IsUnicode(false);

                entity.Property(e => e.FormulaM2).IsUnicode(false);

                entity.Property(e => e.FormulaM3).IsUnicode(false);

                entity.Property(e => e.FormulaM4).IsUnicode(false);

                entity.Property(e => e.FormulaM5).IsUnicode(false);

                entity.Property(e => e.FormulaM6).IsUnicode(false);

                entity.Property(e => e.FormulaM7).IsUnicode(false);

                entity.Property(e => e.FormulaM8).IsUnicode(false);

                entity.Property(e => e.FormulaM9).IsUnicode(false);
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.Property(e => e.LocationName).IsUnicode(false);
            });

            modelBuilder.Entity<Months>(entity =>
            {
                entity.Property(e => e.MonthName).IsUnicode(false);
            });

            modelBuilder.Entity<Rectypes>(entity =>
            {
                entity.Property(e => e.RecordTypeName).IsUnicode(false);
            });

            modelBuilder.Entity<TemplateDetails>(entity =>
            {
                entity.Property(e => e.Company).IsUnicode(false);

                entity.Property(e => e.CostCenter).IsUnicode(false);

                entity.Property(e => e.Div).IsUnicode(false);

                entity.Property(e => e.Year).IsUnicode(false);

                entity.HasOne(d => d.UserGroup1Navigation)
                    .WithMany(p => p.TemplateDetailsUserGroup1Navigation)
                    .HasForeignKey(d => d.UserGroup1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TemplateDetails_Users");

                entity.HasOne(d => d.UserGroup2Navigation)
                    .WithMany(p => p.TemplateDetailsUserGroup2Navigation)
                    .HasForeignKey(d => d.UserGroup2)
                    .HasConstraintName("FK_TemplateDetails_Users1");

                entity.HasOne(d => d.UserGroup3Navigation)
                    .WithMany(p => p.TemplateDetailsUserGroup3Navigation)
                    .HasForeignKey(d => d.UserGroup3)
                    .HasConstraintName("FK_TemplateDetails_Users2");
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.Property(e => e.Ed).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transactions_Accounts");

                entity.HasOne(d => d.Month)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.MonthId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transactions_Months");

                entity.HasOne(d => d.Rectype)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.RectypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transactions_Rectypes");

                entity.HasOne(d => d.TemplateDetails)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.TemplateDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transactions_TemplateDetails");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transactions_Users");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.AuthCode).IsUnicode(false);

                entity.Property(e => e.UserName).IsUnicode(false);
            });
        }
    }
}
