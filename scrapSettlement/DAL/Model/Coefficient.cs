using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ScrapSettlement.DAL.Model
{
    class Coefficient
    {
        public int CoefficientID { get; set; }
        public int CustomerID { get; set;  }
        public int ScrapID { get; set; }
        public float Data { get; set; }
        public DateTime EffectDate { get; set; }
        public DateTime FailureDate { get; set; }   

    }
}
