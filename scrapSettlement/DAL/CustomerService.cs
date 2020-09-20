using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Utility;

namespace ScrapSettlement.DAL
{
   public class CustomerService
    {
        public List<Customer> getCustomerList()
        {
            List<Customer> listCustomer = new List<Customer>();
            string sql = "select * from customerSet where 1=@queryAll";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@queryAll",1 )
            };

            SqlDataReader sqlDataReader = Utility.Sql.Sqlhelper.GetSqlDataReader(sql, sqlParameters);
            while (sqlDataReader.Read())
            {
                Customer customer = new Customer();
                customer.cusCode = sqlDataReader["cusCode"].ToString();
                customer.cusName = sqlDataReader["cusName"].ToString();
                customer.effectDate = sqlDataReader.GetDateTime(3);
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
