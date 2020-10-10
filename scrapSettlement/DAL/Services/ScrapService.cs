using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScrapSettlement.DAL.Model;

namespace ScrapSettlement.DAL.Services
{
    class ScrapService

    {
        public List<Scrap> scrapList()
        {
            using (var db=new ScrapSettleContext())
            {
                return db.Scraps.ToList<Scrap>();
            }
        }
    }
}
