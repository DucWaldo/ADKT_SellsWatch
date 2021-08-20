namespace ADKT_SellsWatch.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Receipt_Details
    {
        [Key]
        public int Number { get; set; }

        [Required]
        [StringLength(50)]
        public string WatchID { get; set; }

        public int ReceiptID { get; set; }

        public int numOfWatch { get; set; }

        public virtual Receipt Receipt { get; set; }

        public virtual Watch Watch { get; set; }
    }
}
