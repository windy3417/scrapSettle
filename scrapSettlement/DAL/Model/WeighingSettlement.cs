using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace ScrapSettlement.DAL.Model
{
    class WeighingSettlement
    {
        [Key]
        public string vocherNO { get; set; }
        public DateTime MakeDate { get; set; }
        public DateTime WeighingDate { get; set; }
        public string CustmerCode { get; set; }
        public string personCode { get; set; }
        public string scrapCode { get; set; }
        public double GrossWeght { get; set; }
        public double Tare { get; set; }
        public String VehicleBrand { get; set; }
        public double netWeight { get; set; }
        public double proportion { get; set; }
        public double webUnitPrice { get; set; }
        public double settleUnitPrice { get; set; }
        public double settleAmount { get; set; }
      

    }
}
