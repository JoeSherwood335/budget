using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace budget.Models
{
    [Table("AccountCategories", Schema = "Options")]
    public partial class AccountCategories
    {
        public AccountCategories()
        {
            Accounts = new HashSet<Accounts>();
        }

        [Key]
        public int AccountCategoryId { get; set; }
        [Required]
        [StringLength(3)]
        public string AccountCategory { get; set; }
        [Required]
        [StringLength(50)]
        public string AccountCategoryDesc { get; set; }
        public bool Discontinued { get; set; }

        [InverseProperty("AccountCategoryNavigation")]
        public ICollection<Accounts> Accounts { get; set; }
    }
}
