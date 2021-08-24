namespace ADKT_SellsWatch.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        [Key]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        public bool? Gender { get; set; }

        public DateTime? BirthDay { get; set; }

        public DateTime? WorkDay { get; set; }

        [StringLength(11)]
        public string Phone { get; set; }

        public decimal? Salary { get; set; }

        public bool? Status { get; set; }
    }
}
