using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace budget.Models
{
    [Table("Companies", Schema = "admin")]
    public partial class Companies
    {
        [Key]
        public int CompanyId { get; set; }
        [Required]
        [StringLength(10)]
        public string CompanyName { get; set; }
        [Required]
        [StringLength(50)]
        public string CompanyDesc { get; set; }
        public bool Discontinued { get; set; }
    }
}
