using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace budget.Models
{
    [Table("AccountGroups", Schema = "Options")]
    public partial class AccountGroups
    {
        public AccountGroups()
        {
            Accounts = new HashSet<Accounts>();
        }

        [Key]
        public int AccountGroupId { get; set; }
        [Required]
        [StringLength(3)]
        public string AccountGroup { get; set; }
        [Required]
        [StringLength(50)]
        public string AccountGroupDesc { get; set; }
        public bool Discontinued { get; set; }

        [InverseProperty("AccountGroupNavigation")]
        public ICollection<Accounts> Accounts { get; set; }
    }
}
