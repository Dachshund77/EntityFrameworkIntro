namespace EntityFrameworkIntro.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_FinishedEducation
    {
        [Key]
        public int fld_FinishedEducationID { get; set; }

        public int fld_AmuNR { get; set; }

        public int fld_InterviewID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fld_FinishedDate { get; set; }

        public virtual tbl_Education tbl_Education { get; set; }

        public virtual tbl_Interview tbl_Interview { get; set; }
    }
}
