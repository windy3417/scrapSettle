using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScrapSettlement.DAL.Model;

namespace ScrapSettlement.DAL.Services
{
    class IncomeService

    {
        public List<Income> incomes()
        {
            using (var db=new ScrapSettleContext())
            {
                return db.Incomes.ToList();
            }
        }
    }
}
