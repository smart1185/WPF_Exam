namespace Wpfexam.Module
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class books
    {
        [Key]
        public int Idbook { get; set; }

        [StringLength(256)]
        public string BookName { get; set; }

        [StringLength(256)]
        public string BookPublisherName { get; set; }

        public int? BookPublisheredYear { get; set; }

        public decimal? BookPrice { get; set; }

        public int? BookQuantity { get; set; }
    }
}
