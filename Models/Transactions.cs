using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace budget.Models
{
    [Table("Transactions", Schema = "archive")]
    public partial class Transactions
    {
        [Key]
        public int TransactionId { get; set; }
        public int TemplateDetailsId { get; set; }
        public int RectypeId { get; set; }
        public int MonthId { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal Version { get; set; }
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        public int UserId { get; set; }
        [Column("ed", TypeName = "datetime")]
        public DateTime Ed { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        public int AccountId { get; set; }

        [ForeignKey("AccountId")]
        [InverseProperty("Transactions")]
        public Accounts Account { get; set; }
        [ForeignKey("MonthId")]
        [InverseProperty("Transactions")]
        public Months Month { get; set; }
        [ForeignKey("RectypeId")]
        [InverseProperty("Transactions")]
        public Rectypes Rectype { get; set; }
        [ForeignKey("TemplateDetailsId")]
        [InverseProperty("Transactions")]
        public TemplateDetails TemplateDetails { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("Transactions")]
        public Users User { get; set; }
    }
}
