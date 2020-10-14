using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScrapSettlement.DAL.Model;

namespace ScrapSettlement.DAL.Services
{
    class PersonService

    {
        public List<Person> people()
        {
            using (var db=new ScrapSettleContext())
            {
                return db.Peple.ToList();
            }
        }
    }
}
