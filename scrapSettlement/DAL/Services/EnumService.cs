using ScrapSettlement.DAL.Modle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScrapSettlement.DAL.Services
{
 public   class EnumService
    {
        public Dictionary<int, String> GetVoucherState()
        {
            Dictionary<int, String> keyValuePairs = new Dictionary<int, string>();

            foreach (string value in Enum.GetNames(typeof(EnumModle.voucherStatus)))
            {
                int key = Convert.ToInt32(Enum.Parse(typeof(EnumModle.voucherStatus), value));
                keyValuePairs.Add(key, value); //添加keyvalue键值对


            }
            return keyValuePairs;
        }
    }
}
