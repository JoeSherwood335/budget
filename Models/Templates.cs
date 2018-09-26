using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace budget.Models
{
    [Table("Templates", Schema = "admin")]
    public partial class Templates
    {
        [Key]
        public int TemplateId { get; set; }
        public int Year { get; set; }
    }
}
