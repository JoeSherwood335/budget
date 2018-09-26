using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace budget.Models
{
    [Table("Employees", Schema = "admin")]
    public partial class Employees
    {
        [Key]
        public int Pid { get; set; }
        [StringLength(10)]
        public string CompanyCode { get; set; }
        [StringLength(10)]
        public string AdpCompany { get; set; }
        [Column("cc")]
        [StringLength(3)]
        public string Cc { get; set; }
        [StringLength(6)]
        public string FileAs { get; set; }
        [Column("FIRSTNAME")]
        [StringLength(50)]
        public string Firstname { get; set; }
        [Column("LASTNAME")]
        [StringLength(50)]
        public string Lastname { get; set; }
        [StringLength(255)]
        public string JobDesc { get; set; }
        [Column("TOTAL", TypeName = "money")]
        public decimal? Total { get; set; }
        [Column("TOTALNEW", TypeName = "money")]
        public decimal? Totalnew { get; set; }
        [Column("acct")]
        [StringLength(3)]
        public string Acct { get; set; }
        [Column("NEWEMPLOYE")]
        public bool? Newemploye { get; set; }
        [Column("SPLITCOSTC")]
        public bool? Splitcostc { get; set; }
        [Column("DATALOCK")]
        public bool Datalock { get; set; }
        [Column("WC")]
        [StringLength(50)]
        public string Wc { get; set; }
        [Column("MONTHSTART")]
        public double? Monthstart { get; set; }
        [Column("NUMBERMONT")]
        public double? Numbermont { get; set; }
        [Column("ANIVDATE", TypeName = "datetime")]
        public DateTime? Anivdate { get; set; }
        [Column("h1")]
        [StringLength(50)]
        public string H1 { get; set; }
        [Column("h1p")]
        public int? H1p { get; set; }
        [Column("h2")]
        [StringLength(50)]
        public string H2 { get; set; }
        [Column("h2p")]
        public int? H2p { get; set; }
        [Column("h3")]
        [StringLength(50)]
        public string H3 { get; set; }
        [Column("h3p")]
        public int? H3p { get; set; }
        [Column("h4")]
        [StringLength(50)]
        public string H4 { get; set; }
        [Column("h4p")]
        public int? H4p { get; set; }
        [Column("h5")]
        [StringLength(50)]
        public string H5 { get; set; }
        [Column("h5p")]
        public int? H5p { get; set; }
        [Column("h6")]
        [StringLength(50)]
        public string H6 { get; set; }
        [Column("h6p")]
        public int? H6p { get; set; }
        [StringLength(50)]
        public string InputSource { get; set; }
        [Column("ED", TypeName = "smalldatetime")]
        public DateTime? Ed { get; set; }
        [Column("UD", TypeName = "smalldatetime")]
        public DateTime? Ud { get; set; }
        [Column("txtAdmin")]
        [StringLength(255)]
        public string TxtAdmin { get; set; }
        [Column("BWC")]
        public int? Bwc { get; set; }
        [Column("BWCRate")]
        public double? Bwcrate { get; set; }
        [Column(TypeName = "money")]
        public decimal? HealthSubsidy { get; set; }
        [Column("SSN")]
        [StringLength(11)]
        public string Ssn { get; set; }
        [Column(TypeName = "money")]
        public decimal? HourlyRate { get; set; }
        [Column(TypeName = "money")]
        public decimal? HourlyRateNew { get; set; }
        public int? TotalHours { get; set; }
        public int? TotalHoursNew { get; set; }
        [Column("R2Kname")]
        [StringLength(50)]
        public string R2kname { get; set; }
    }
}
