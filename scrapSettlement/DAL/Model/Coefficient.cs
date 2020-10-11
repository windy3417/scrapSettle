using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScrapSettlement.DAL.Model
{
    class Coefficient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int CoefficientID { get; set; }
        [Key]
        public string VoucherNO { get; set; }

        public int CustomerID { get; set;  }
        public int ScrapID { get; set; }
        public Double Data { get; set; }
        public DateTime EffectDate { get; set; }

        public Nullable<DateTime> FailureDate { get; set; }
       

    }
}
