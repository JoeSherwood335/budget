using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace budget.Models
{
    [Table("Locations", Schema = "Options")]
    public partial class Locations
    {
        [Key]
        public int LocationId { get; set; }
        [Required]
        [StringLength(50)]
        public string LocationName { get; set; }
        public bool Discontinued { get; set; }
    }
}
