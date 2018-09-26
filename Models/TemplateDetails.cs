using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace budget.Models
{
    [Table("TemplateDetails", Schema = "admin")]
    public partial class TemplateDetails
    {
        public TemplateDetails()
        {
            Transactions = new HashSet<Transactions>();
        }

        public int TemplateDetailsId { get; set; }
        public int UserGroup1 { get; set; }
        public int? UserGroup2 { get; set; }
        public int? UserGroup3 { get; set; }
        public bool Discontinued { get; set; }
        [Required]
        [StringLength(3)]
        public string CostCenter { get; set; }
        [Required]
        [StringLength(3)]
        public string Div { get; set; }
        [Required]
        [StringLength(3)]
        public string Company { get; set; }
        [Required]
        [StringLength(4)]
        public string Year { get; set; }

        [ForeignKey("UserGroup1")]
        [InverseProperty("TemplateDetailsUserGroup1Navigation")]
        public Users UserGroup1Navigation { get; set; }
        [ForeignKey("UserGroup2")]
        [InverseProperty("TemplateDetailsUserGroup2Navigation")]
        public Users UserGroup2Navigation { get; set; }
        [ForeignKey("UserGroup3")]
        [InverseProperty("TemplateDetailsUserGroup3Navigation")]
        public Users UserGroup3Navigation { get; set; }
        [InverseProperty("TemplateDetails")]
        public ICollection<Transactions> Transactions { get; set; }
    }
}
