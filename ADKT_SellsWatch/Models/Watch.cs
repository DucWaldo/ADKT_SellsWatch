namespace ADKT_SellsWatch.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Watch")]
    public partial class Watch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Watch()
        {
            Receipt_Details = new HashSet<Receipt_Details>();
        }

        [StringLength(50)]
        public string WatchID { get; set; }

        public string WatchName { get; set; }

        public bool? Gender { get; set; }

        [StringLength(50)]
        public string Glass { get; set; }

        [StringLength(50)]
        public string Waterproof { get; set; }

        [StringLength(50)]
        public string Strap { get; set; }

        public decimal Price { get; set; }

        public int BrandID { get; set; }

        public int? NumOfItem { get; set; }

        public virtual Brand Brand { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt_Details> Receipt_Details { get; set; }
    }
}
