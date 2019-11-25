namespace EntityFrameworkIntro.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Date
    {
        [Key]
        public int fld_DateID { get; set; }

        public int fld_AmuNr { get; set; }

        [Column(TypeName = "date")]
        public DateTime fld_Date { get; set; }

        public virtual tbl_Education tbl_Education { get; set; }
    }
}
