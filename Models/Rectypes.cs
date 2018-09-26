using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace budget.Models
{
    [Table("Rectypes", Schema = "Options")]
    public partial class Rectypes
    {
        public Rectypes()
        {
            Transactions = new HashSet<Transactions>();
        }

        [Key]
        public int RectypeId { get; set; }
        [Required]
        [StringLength(15)]
        public string RecordTypeName { get; set; }

        [InverseProperty("Rectype")]
        public ICollection<Transactions> Transactions { get; set; }
    }
}
