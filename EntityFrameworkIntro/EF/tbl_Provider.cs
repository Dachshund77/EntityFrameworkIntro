namespace EntityFrameworkIntro.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Provider
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Provider()
        {
            tbl_Education = new HashSet<tbl_Education>();
        }

        [Key]
        public int fld_ProviderID { get; set; }

        [Required]
        [StringLength(30)]
        public string fld_ProviderName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Education> tbl_Education { get; set; }
    }
}
