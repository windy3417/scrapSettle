﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScrapSettlement.DAL.Model
{
    class WeighingSettlement
    {

        public int Id { get; set; }
        public string vocherNO { get; set; }
        public string CustmerCode { get; set; }
        public string personCode { get; set; }
        public string scrapCode { get; set; }
        public double netWeight { get; set; }
        public double proportion { get; set; }
        public double webUnitPrice { get; set; }
        public double settleUnitPrice { get; set; }
        public double settleAmount { get; set; }
        public int Customer_Id { get; set; }

        public virtual Customer Customers { get; set; }
    }
}