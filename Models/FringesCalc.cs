using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace budget.Models
{
    [Table("FringesCalc", Schema = "admin")]
    public partial class FringesCalc
    {
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("fName")]
        [StringLength(50)]
        public string FName { get; set; }
        [Required]
        [StringLength(3)]
        public string Account { get; set; }
        [Required]
        [StringLength(3)]
        public string BaseAccount { get; set; }
        [Required]
        [StringLength(50)]
        public string FormulaM1 { get; set; }
        [Required]
        [StringLength(50)]
        public string FormulaM2 { get; set; }
        [Required]
        [StringLength(50)]
        public string FormulaM3 { get; set; }
        [Required]
        [StringLength(50)]
        public string FormulaM4 { get; set; }
        [Required]
        [StringLength(50)]
        public string FormulaM5 { get; set; }
        [Required]
        [StringLength(50)]
        public string FormulaM6 { get; set; }
        [Required]
        [StringLength(50)]
        public string FormulaM7 { get; set; }
        [Required]
        [StringLength(50)]
        public string FormulaM8 { get; set; }
        [Required]
        [StringLength(50)]
        public string FormulaM9 { get; set; }
        [Required]
        [StringLength(50)]
        public string FormulaM10 { get; set; }
        [Required]
        [StringLength(50)]
        public string FormulaM11 { get; set; }
        [Required]
        [StringLength(50)]
        public string FormulaM12 { get; set; }
        [Column("CCException")]
        [StringLength(400)]
        public string Ccexception { get; set; }
        [StringLength(400)]
        public string CompExceptions { get; set; }
    }
}
