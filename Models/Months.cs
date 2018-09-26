using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace budget.Models
{
    [Table("Months", Schema = "Options")]
    public partial class Months
    {
        public Months()
        {
            Transactions = new HashSet<Transactions>();
        }

        [Key]
        public int MonthId { get; set; }
        public int MonthNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string MonthName { get; set; }

        [InverseProperty("Month")]
        public ICollection<Transactions> Transactions { get; set; }
    }
}
