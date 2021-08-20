namespace ADKT_SellsWatch.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Membership")]
    public partial class Membership
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Membership()
        {
            Receipts = new HashSet<Receipt>();
        }

        [Key]
        [StringLength(11)]
        public string CustomerPhone { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDay { get; set; }

        [StringLength(10)]
        public string Genner { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CardDay { get; set; }

        public int? NumOfOrder { get; set; }

        public int? RankID { get; set; }

        public virtual Rank Rank { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt> Receipts { get; set; }
    }
}
