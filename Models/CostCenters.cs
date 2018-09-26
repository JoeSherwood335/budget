using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace budget.Models
{
    [Table("CostCenters", Schema = "admin")]
    public partial class CostCenters
    {
        [Key]
        public int CostCenterId { get; set; }
        [Required]
        [StringLength(3)]
        public string CostCenter { get; set; }
        [Required]
        [StringLength(255)]
        public string CostCenterName { get; set; }
        public bool Discontinued { get; set; }
    }
}
