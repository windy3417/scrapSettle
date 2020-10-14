using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScrapSettlement.DAL.Model;

namespace ScrapSettlement.DAL.Services
{
    class WeighingRegisterService
    {
        public List<WeighingSettlement> weighingSettlements()
        {
            using (var db=new ScrapSettleContext())
            {
                return db.WeighingSettlement.ToList();
            }
        }
    }
}
