using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace budget.Models
{
    [Table("Divisions", Schema = "admin")]
    public partial class Divisions
    {
        [Key]
        public int DivisionId { get; set; }
        [Required]
        [StringLength(3)]
        public string Division { get; set; }
        [Required]
        [StringLength(50)]
        public string DivisionDesc { get; set; }
        public bool Discontinued { get; set; }
    }
}
