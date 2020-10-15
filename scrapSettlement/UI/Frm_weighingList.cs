
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using ScrapSettlement.DAL;
using System.Collections.Generic;
using System.Configuration;
using Utility;
using ScrapSettlement.DAL.Model;
using ScrapSettlement.DAL.Services;

namespace ScrapSettlement.UI
{
    public partial class Frm_weighingList : Form
    {
        public Frm_weighingList()
        {
            InitializeComponent();
            this.initialize();

        }

        #region 变量
        //新增时,dataGridview绑定的数据源，以体现新增的结果
        List<Income> incomeList = new List<Income>();
     

        #endregion


        /// <summary>
        /// 初始化控件
        /// </summary>
        private void initialize()
        {
            this.FormClosed += new FormClosedEventHandler(this.closeParent);

            this.dataGridView1.AutoGenerateColumns = false;
      

            //初始化客户名称数据源

            cmb_custName.DataSource = new CustomerService().getCustomerList().Where<Customer>(c => c.FailuerDate == null).Select((c) => new { c.CusCode, c.CusName }).ToList();

            cmb_custName.DisplayMember = "CusName";
            cmb_custName.ValueMember = "CusCode";



        }

     
                                                                 
        /// <summary>
        /// 查询收款单列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_query_Click(object sender, EventArgs e)
        {

            using (var db = new ScrapSettleContext())
            {
                                               
                try
                {
                    var query = from q in db.WeighingSettlement
                                join c in db.Customers
                                on q.CustmerCode equals c.CusCode.ToString()
                                join p in db.Peple on q.personCode equals p.Code.ToString()
                                join s in db.Scraps on q.scrapCode equals s.ScrapCode.ToString()
                                where q.WeighingDate>=dtp_incomeDateStart.Value.Date 
                                where q.WeighingDate<=dtp_incomeDateEnd.Value.Date
                                where q.CustmerCode.ToString() == cmb_custName.SelectedValue.ToString()
                             
                                select new { q.WeighingDate, q.vocherNO, c.CusName, s.ScrapName,q.proportion, q.webUnitPrice, q.settleUnitPrice, q.netWeight, q.settleAmount };
                                dataGridView1.DataSource = query.ToList();
                    //处理数据为空示和时的数据转换错误，可先转成泛型再求和
                    lbl_money.Text = query.ToList().Sum(s =>s.settleAmount).ToString("C");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("数据查询错误:" + ex.Message + ex.InnerException, "数据查询提示");
                    return;
                }

            }


        }

        private void closeParent(object seder, FormClosedEventArgs eventArgs)
        {
            this.Parent.Dispose();
        }

        private void Tsb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_query_Click(object sender, EventArgs e)
        {
            tsb_query.PerformClick();
        }
    }







};






    











    
