using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScrapSettlement.DAL.Model
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public int CusCode { get; set; }
        public string CusName { get; set; }
        public DateTime EffectDate { get; set; }
        
        public DateTime FailuerDate { get;

            set; }
    }
}
