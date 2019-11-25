namespace EntityFrameworkIntro.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WtfDoICallThis : DbContext
    {
        public WtfDoICallThis()
            : base("name=WtfDoICallThis")
        {
        }

        public virtual DbSet<tbl_Company> tbl_Company { get; set; }
        public virtual DbSet<tbl_Consultation> tbl_Consultation { get; set; }
        public virtual DbSet<tbl_Date> tbl_Date { get; set; }
        public virtual DbSet<tbl_Education> tbl_Education { get; set; }
        public virtual DbSet<tbl_EducationWish> tbl_EducationWish { get; set; }
        public virtual DbSet<tbl_Employee> tbl_Employee { get; set; }
        public virtual DbSet<tbl_FinishedEducation> tbl_FinishedEducation { get; set; }
        public virtual DbSet<tbl_Interview> tbl_Interview { get; set; }
        public virtual DbSet<tbl_Provider> tbl_Provider { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_Company>()
                .Property(e => e.fld_CvrNr)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Company>()
                .Property(e => e.fld_CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Consultation>()
                .Property(e => e.fld_ConsultationName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Consultation>()
                .HasMany(e => e.tbl_Employee)
                .WithMany(e => e.tbl_Consultation)
                .Map(m => m.ToTable("tbl_Consultation_Employee_Bridge").MapLeftKey("fld_ConsultationID").MapRightKey("fld_EmployeeID"));

            modelBuilder.Entity<tbl_Education>()
                .Property(e => e.fld_EducationName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Employee>()
                .Property(e => e.fld_EmployeeFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Employee>()
                .Property(e => e.fld_EmployeeLastName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Employee>()
                .Property(e => e.fld_CprNr)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Employee>()
                .Property(e => e.fld_Email)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Employee>()
                .Property(e => e.fld_PhoneNr)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Employee>()
                .HasMany(e => e.tbl_Interview)
                .WithRequired(e => e.tbl_Employee)
                .HasForeignKey(e => e.fld_Employee_ID);

            modelBuilder.Entity<tbl_Interview>()
                .Property(e => e.fld_InterviewName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Provider>()
                .Property(e => e.fld_ProviderName)
                .IsUnicode(false);
        }
    }
}
