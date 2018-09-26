using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace budget.Models
{
    [Table("Accounts", Schema = "admin")]
    public partial class Accounts
    {
        public Accounts()
        {
            Transactions = new HashSet<Transactions>();
        }

        [Key]
        public int AccountId { get; set; }
        public int Account { get; set; }
        [Required]
        [StringLength(50)]
        public string AccountDesc { get; set; }
        public int AccountGroup { get; set; }
        public int AccountCategory { get; set; }

        [ForeignKey("AccountCategory")]
        [InverseProperty("Accounts")]
        public AccountCategories AccountCategoryNavigation { get; set; }
        [ForeignKey("AccountGroup")]
        [InverseProperty("Accounts")]
        public AccountGroups AccountGroupNavigation { get; set; }
        [InverseProperty("Account")]
        public ICollection<Transactions> Transactions { get; set; }
    }
}
