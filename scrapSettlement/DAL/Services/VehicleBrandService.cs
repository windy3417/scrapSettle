using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScrapSettlement.DAL;
using ScrapSettlement.DAL.Model;

namespace ScrapSettlement.DAL.Services
{
    class VehicleBrandService

    {
        public List<VehicleBrand> vehicleBrands()
        {
            using (var db =new ScrapSettleContext())
            {
                return db.VehicleBrands.ToList();
            }
        }
    }
}
