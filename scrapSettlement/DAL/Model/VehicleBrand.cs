using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ScrapSettlement.DAL.Model
{
    class VehicleBrand
    {
        [Key]
        public string VehicleBrandValue { get; set; }  
        public int CustomerID { get; set; }
        public DateTime EffectDate { get; set; }


        public Nullable<System.DateTime> FailuerDate
        {
            get;

            set;
        }
    }
}
