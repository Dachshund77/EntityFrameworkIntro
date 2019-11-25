namespace EntityFrameworkIntro.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Education
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Education()
        {
            tbl_Date = new HashSet<tbl_Date>();
            tbl_EducationWish = new HashSet<tbl_EducationWish>();
            tbl_FinishedEducation = new HashSet<tbl_FinishedEducation>();
        }

        [Key]
        public int fld_AmuNR { get; set; }

        public int fld_ProviderID { get; set; }

        [Required]
        [StringLength(30)]
        public string fld_EducationName { get; set; }

        public string fld_Description { get; set; }

        public int fld_NoOfDays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Date> tbl_Date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_EducationWish> tbl_EducationWish { get; set; }

        public virtual tbl_Provider tbl_Provider { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FinishedEducation> tbl_FinishedEducation { get; set; }
    }
}
