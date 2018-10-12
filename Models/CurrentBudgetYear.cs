using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace budget.Models{
//[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
//[Key]
//[ForeignKeyAttribute("key")]
  [Table("CurrentBudgetYear",Schema="cfg")]
   public class CurrentBudgetYear
   {

     public CurrentBudgetYear()
     {
     }

     public string Year { get; set; }
   }

}  //end namespace