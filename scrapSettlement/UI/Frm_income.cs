using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ScrapSettlement.DAL.Services;
using ScrapSettlement.DAL.Model;
using ScrapSettlement.DAL;
using ScrapSettlement.Common;

namespace ScrapSettlement
{
    public partial class Frm_income : Form
    {
        public Frm_income()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(this.closeParent);
            this.tableLayoutPanel1.Enabled = false;
        }

        /// <summary>
        /// 初始化控件及数据源
        /// </summary>
        private void initiallize()
        {
            //初始化客户名称数据源

            cmb_custName.DataSource = new CustomerService().getCustomerList().Where<Customer>(c => c.FailuerDate == null).Select((c) => new { c.CusCode, c.CusName }).ToList();

            cmb_custName.DisplayMember = "CusName";
            cmb_custName.ValueMember = "CusCode";
        }

        private void Tsb_print_Click(object sender, EventArgs e)
        {

            this.printPreviewDialog1.Show();
        }

        private void Tsb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeParent(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        /// <summary>
        /// 新增收款单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_new_Click(object sender, EventArgs e)
        {
            tsb_save.Enabled = true;
            this.tableLayoutPanel1.Enabled = true;
            this.lbl_vouchNoValue.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
            initiallize();
        }

        /// <summary>
        /// 保存收款单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_save_Click(object sender, EventArgs e)
        {
            
            if (new ValidateClear().inputVlidate(tableLayoutPanel1))
            {
                using (var db = new ScrapSettleContext())
                {
                    Income income = new Income();
                    income.CustormerID = Convert.ToInt32(cmb_custName.SelectedValue);
                    income.MakeDte = dtp_make.Value;
                    income.Money = Convert.ToDouble(txt_money.Text);
                    income.VoucherNo = lbl_vouchNoValue.Text;
                    income.IncomeDate = dtp_income.Value;

                    try
                    {
                        db.Incomes.Add(income);
                        db.SaveChanges();
                        tsb_save.Enabled = false;
                        new ValidateClear().clearDate(tableLayoutPanel1);

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("数据保存错误:" + ex.Message + ex.InnerException, "数据保存提示");
                        return;
                    }


                }
            }
           
        }

        private void Frm_income_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.S && e.Control)
            {
                tsb_save.PerformClick(); //执行单击button1的动作 
                
            }
            //if (e.KeyCode == Keys.Delete)
            //{
            //    tsb_delete.PerformClick();
            //}
        }
    }
}

