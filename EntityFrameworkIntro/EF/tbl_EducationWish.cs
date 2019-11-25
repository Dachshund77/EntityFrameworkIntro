namespace EntityFrameworkIntro.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_EducationWish
    {
        [Key]
        public int fld_EducationWishID { get; set; }

        public int fld_AmuNR { get; set; }

        public int fld_InterviewID { get; set; }

        public int fld_WishPriority { get; set; }

        public virtual tbl_Education tbl_Education { get; set; }

        public virtual tbl_Interview tbl_Interview { get; set; }
    }
}
