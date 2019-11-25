namespace EntityFrameworkIntro.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Consultation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Consultation()
        {
            tbl_Employee = new HashSet<tbl_Employee>();
        }

        [Key]
        public int fld_ConsultationID { get; set; }

        [Required]
        [StringLength(50)]
        public string fld_ConsultationName { get; set; }

        [Column(TypeName = "date")]
        public DateTime fld_StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime fld_EndDate { get; set; }

        public int fld_CompanyID { get; set; }

        public virtual tbl_Company tbl_Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Employee> tbl_Employee { get; set; }
    }
}
