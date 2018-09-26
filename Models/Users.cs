using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace budget.Models
{
    [Table("Users", Schema = "admin")]
    public partial class Users
    {
        public Users()
        {
            TemplateDetailsUserGroup1Navigation = new HashSet<TemplateDetails>();
            TemplateDetailsUserGroup2Navigation = new HashSet<TemplateDetails>();
            TemplateDetailsUserGroup3Navigation = new HashSet<TemplateDetails>();
            Transactions = new HashSet<Transactions>();
        }

        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [StringLength(5)]
        public string AuthCode { get; set; }
        public int? SupervisorId { get; set; }
        public bool Discontinued { get; set; }

        [InverseProperty("UserGroup1Navigation")]
        public ICollection<TemplateDetails> TemplateDetailsUserGroup1Navigation { get; set; }
        [InverseProperty("UserGroup2Navigation")]
        public ICollection<TemplateDetails> TemplateDetailsUserGroup2Navigation { get; set; }
        [InverseProperty("UserGroup3Navigation")]
        public ICollection<TemplateDetails> TemplateDetailsUserGroup3Navigation { get; set; }
        [InverseProperty("User")]
        public ICollection<Transactions> Transactions { get; set; }
    }
}
