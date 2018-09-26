using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace budget.Models
{
    [Table("Dashboard", Schema = "cfg")]
    public partial class Dashboard
    {
        public int DashBoardId { get; set; }
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Value { get; set; }
    }
}
