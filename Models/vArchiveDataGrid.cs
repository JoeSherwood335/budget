using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace budget.Models{
//[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
//[Key]
//[ForeignKeyAttribute("key")]
   public class vArchiveDataGrid
   {

      public vArchiveDataGrid()
      {

      }
    
      public string RecordTypeName { get; set; }
      public string Year { get; set; }
      public string CompanyName { get; set; }
      public string CostCenter { get; set; }
      public int Account { get; set; }
      public Decimal January { get; set; }
      public decimal Feburary { get; set; }
      public decimal March { get; set; }  
      public decimal April { get; set; }
      public decimal May { get; set; }
      public decimal June { get; set; }
      public decimal July { get; set; }
      public decimal August { get; set; }
      public decimal September { get; set; }
      public decimal October { get; set; }
      public decimal November { get; set; }
      public decimal December { get; set; }

   }
}  //end namespace