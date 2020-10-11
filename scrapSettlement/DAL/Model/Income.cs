using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ScrapSettlement.DAL.Model
{
    class Income
    {
        [Key]
        public string VoucherNo { get; set; }
        public int CustormerID { get; set; }
        public decimal Money { get; set; }
        public DateTime IncomeDate { get; set; }
        public DateTime MakeDte { get; set; }

    }
}
