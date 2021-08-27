namespace ADKT_SellsWatch.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Receipt")]
    public partial class Receipt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Receipt()
        {
            Receipt_Details = new HashSet<Receipt_Details>();
        }

        public int ReceiptID { get; set; }

        [StringLength(15)]
        public string CustomerID { get; set; }

        [StringLength(50)]
        public string StaffID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public decimal? TotalPrice { get; set; }

        public virtual Membership Membership { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt_Details> Receipt_Details { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
