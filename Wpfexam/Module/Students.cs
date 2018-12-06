namespace Wpfexam.Module
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Students
    {
        [Key]
        public int IdStudent { get; set; }

        [StringLength(256)]
        public string NameStudent { get; set; }

        [StringLength(256)]
        public string Branch { get; set; }

        [StringLength(256)]
        public string YearStudy { get; set; }
    }
}
