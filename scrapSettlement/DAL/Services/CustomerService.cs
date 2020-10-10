using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Utility;
using ScrapSettlement.DAL.Model;

namespace ScrapSettlement.DAL.Services
{
   public class CustomerService
    {
        public List<Customer> getCustomerList()
        {
            List<Customer> listCustomer = new List<Customer>();
            string sql = "select * from customers where 1=@queryAll";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@queryAll",1 )
            };

            SqlDataReader sqlDataReader = Utility.Sql.Sqlhelper.GetSqlDataReader(sql, sqlParameters);
            while (sqlDataReader.Read())
            {
                Customer customer = new Customer();
                customer.CusCode =Convert.ToInt32( sqlDataReader["cusCode"]);
                customer.CusName = sqlDataReader["cusName"].ToString();
                customer.EffectDate = sqlDataReader.GetDateTime(3);
                if (!sqlDataReader.IsDBNull(4))
                {
                    sqlDataReader.GetDateTime(4);
                }
                                
                listCustomer.Add(customer);
            }
            return listCustomer;
        }

        public void updateCustomer()
        {
           
        }
    }
}
