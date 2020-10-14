using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScrapSettlement.DAL.Model;

namespace ScrapSettlement.DAL.Services
{
    class CoefficientService
    {
        public List<Coefficient> coefficients()
        {
            using (var db=new ScrapSettleContext())
            {
                return db.Coefficients.ToList();
            }
        }
    }
}
