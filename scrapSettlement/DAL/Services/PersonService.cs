using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ScrapSettlement.DAL.Model;
using static Utility.Sql.Sqlhelper;

namespace ScrapSettlement.DAL.Services
{
    class PersonService

    {
        /// <summary>
        /// 返回用户列表
        /// </summary>
        /// <returns></returns>
        public List<Person> people()
        {
            using (var db=new ScrapSettleContext())
            {
                return db.Peple.ToList();
            }
        }

        /// <summary>
        /// 使用Sqlparameters检测登录密码与用户名
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool loginCheckWithSqlparameters(string userID, string pwd)
        {
            
            string sql = "select  *  from  [people] where code=@userID and pwd=@pwd  ";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@userID",userID ),
                new SqlParameter("@pwd",pwd ),
            };

            SqlDataReader sqlDataReader = Utility.Sql.Sqlhelper.GetSqlDataReader(sql, DataSourceType.business, sqlParameters);
            if (sqlDataReader.HasRows)
            {
                return true;

                            }
            return false;
        }
    }
}
