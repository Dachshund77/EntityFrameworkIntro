namespace EntityFrameworkIntro.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Company()
        {
            tbl_Consultation = new HashSet<tbl_Consultation>();
        }

        [Key]
        public int fld_CompanyID { get; set; }

        [Required]
        [StringLength(80)]
        public string fld_CvrNr { get; set; }

        [Required]
        [StringLength(50)]
        public string fld_CompanyName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Consultation> tbl_Consultation { get; set; }
    }
}
