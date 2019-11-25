namespace EntityFrameworkIntro.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Interview
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Interview()
        {
            tbl_EducationWish = new HashSet<tbl_EducationWish>();
            tbl_FinishedEducation = new HashSet<tbl_FinishedEducation>();
        }

        [Key]
        public int fld_InterviewID { get; set; }

        [Required]
        [StringLength(30)]
        public string fld_InterviewName { get; set; }

        public int fld_Employee_ID { get; set; }

        public int? fld_ProductUnderstanding { get; set; }

        public int? fld_ProblemUnderstanding { get; set; }

        public int? fld_Flexibility { get; set; }

        public int? fld_QualityAwareness { get; set; }

        public int? fld_Cooperation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_EducationWish> tbl_EducationWish { get; set; }

        public virtual tbl_Employee tbl_Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FinishedEducation> tbl_FinishedEducation { get; set; }
    }
}
