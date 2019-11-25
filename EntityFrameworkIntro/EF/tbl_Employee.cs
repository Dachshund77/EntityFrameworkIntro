namespace EntityFrameworkIntro.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Employee()
        {
            tbl_Interview = new HashSet<tbl_Interview>();
            tbl_Consultation = new HashSet<tbl_Consultation>();
        }

        [Key]
        public int fld_EmployeeID { get; set; }

        [StringLength(30)]
        public string fld_EmployeeFirstName { get; set; }

        [StringLength(30)]
        public string fld_EmployeeLastName { get; set; }

        [Required]
        [StringLength(10)]
        public string fld_CprNr { get; set; }

        [StringLength(30)]
        public string fld_Email { get; set; }

        [StringLength(20)]
        public string fld_PhoneNr { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Interview> tbl_Interview { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Consultation> tbl_Consultation { get; set; }
    }
}
