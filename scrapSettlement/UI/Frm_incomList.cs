
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
    public partial class Frm_incomeList : Form
    {
        public Frm_incomeList()
        {
            InitializeComponent();
            this.initialize();
            initializeDatasource();

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
      
                                   

        }

        /// <summary>
        /// 初始化控件数据源
        /// </summary>
        private void initializeDatasource()
        {
            cmb_custName.DataSource = new CustomerService().getCustomerList().Where<Customer>(c => c.FailuerDate == null).Select((c) => new { c.CusCode, c.CusName }).ToList();

            cmb_custName.DisplayMember = "CusName";
            cmb_custName.ValueMember = "CusCode";

            dtp_incomeDateStart.Value = DateTime.Now.AddDays(-DateTime.Now.Day+1);
        }

        #region 查询
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
                    var query = from q in db.Incomes
                                join c in db.Customers
                                on q.CustormerID equals c.CusCode
                                where q.IncomeDate >= dtp_incomeDateStart.Value.Date
                                where q.IncomeDate <= dtp_incomeDateEnd.Value.Date
                                where q.CustormerID.ToString() == cmb_custName.SelectedValue.ToString()

                                select new { c.CusName, q.IncomeDate, q.VoucherNo, q.Money };
                    dataGridView1.DataSource = query.ToList();
                    //处理数据为空示和时的数据转换错误，可先转成泛型再求和
                    lbl_money.Text = query.ToList().Sum(s => s.Money).ToString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("数据查询错误:" + ex.Message + ex.InnerException, "数据查询提示");
                    return;
                }

            }


        }

        /// <summary>
        /// 双击表格行穿透查询到单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {

                var voucherNo = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Frm_income frm_income = new Frm_income();
                string tabPageText = frm_income.Text;
                Utility.UI.EmbedForm embedForm = new Utility.UI.EmbedForm();
                //使用母窗体的属性信息，实现动态创建插入页签式窗体
                embedForm.openForm(frm_income, tabPageText, (TabControl)this.Parent.Parent.Parent.Controls["tabControl1"], (Panel)this.TopLevelControl.Controls["panel1"]);
                ToolStrip t = (ToolStrip)frm_income.Controls["ts_income"];

                frm_income.tsb_query.PerformClick();
                frm_income.rtxt_voucherNO.Text = voucherNo;
                frm_income.btn_query.PerformClick();

            }
        }

        #endregion

        #region 快捷键

        /// <summary>
        /// 删除功能快捷键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_incomeList_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                tsb_delete.PerformClick();
            }

        }
        #endregion

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

       

        private void tsb_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var selected = dataGridView1.SelectedRows[0].Cells[1].Value;
                if (DialogResult.Yes == MessageBox.Show("是否确定删除", "删除提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {

                    ScrapSettleContext db = new ScrapSettleContext();

                    List<Income> del = (from d in db.Incomes
                                                    where d.VoucherNo == selected.ToString()
                                                    select d).ToList<Income>();
                    //移除数据库的数据
                    db.Incomes.Remove(del[0]);
                    db.SaveChanges();
                    tsb_query.PerformClick();


                }
            }

            return;
        }
    }







};






    











    
