using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ScrapSettlement.DAL.Model;
using ScrapSettlement.DAL.Services;
using System.Drawing.Drawing2D;
using ScrapSettlement.DAL;

namespace ScrapSettlement
{
    public partial class Frm_weighingSettltement : Form
    {
        public Frm_weighingSettltement()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(this.closeParent);
            this.tableLayoutPanel1.Enabled = false;
            txt_money.Enabled = false;
            txt_settleUnitPrice.Enabled = false;
        }

        /// <summary>
        /// 初始化数据源
        /// </summary>
        private void initialize()
        {
            //初始化客户数据源
            //绑定数据源时，其初始selectedValue为实体对象的所有值，需要执行
            //valueMember设定后才是实体中的一个属性值，如若把valueMember先于
            //数据源绑定，则selectedValue的值为空值，这一特性需要设定selectdValueChanged事件处理程序时要注意
            cmb_custName.DataSource = new CustomerService().getCustomerList().Where<Customer>(c => c.FailuerDate == null).
                Select((c) => new { c.CusCode, c.CusName }).ToList();

            cmb_custName.DisplayMember = "CusName";
            cmb_custName.ValueMember = "CusCode";


            //初始化废料档案数据源

            cmb_scrapName.DataSource = new ScrapService().scrapList().Select(s => new { s.ScrapCode, s.ScrapName }).ToList();
            cmb_scrapName.DisplayMember = "ScrapName";
            cmb_scrapName.ValueMember = "ScrapCode";


            //初始化人员档案
            cmb_person.DataSource = new PersonService().people().Select(s => new { s.Code, s.Name }).ToList();
            cmb_person.DisplayMember = "Name";
            cmb_person.ValueMember = "Code";

       
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



        #region 单据增删改

        /// <summary>
        /// 新增单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_new_Click(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.Enabled = true;
            tsb_save.Enabled = true;
            this.lbl_vouchNoValue.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
            initialize();

        }

        /// <summary>
        /// 保存单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_save_Click(object sender, EventArgs e)
        {
            using (var db = new ScrapSettleContext())
            {
                WeighingSettlement w = new WeighingSettlement();
                w.MakeDate = DateTime.Now;
                w.WeighingDate = dtp_makeDate.Value;
                w.CustmerCode = cmb_custName.SelectedValue.ToString();
                w.netWeight = Convert.ToDouble(txt_netWeight.Text);
                w.personCode = cmb_person.SelectedValue.ToString();
                w.proportion = Convert.ToDouble(txt_coefficient.Text);
                w.scrapCode = cmb_scrapName.SelectedValue.ToString();
                w.vocherNO = lbl_vouchNoValue.Text;
                w.webUnitPrice = Convert.ToDouble(txt_webUnitPrice.Text);
                w.settleUnitPrice = Convert.ToDouble(txt_settleUnitPrice.Text);
                w.settleAmount = Convert.ToDouble(txt_money.Text);
                db.WeighingSettlement.Add(w);

                try
                {
                    db.SaveChanges();
                    tsb_save.Enabled = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + ex.InnerException, "保存错误提示");
                }

            }
        }

        #endregion

        #region 界面值变更事件处理方法

        /// <summary>
        /// 该事件在绑定数据源时就会发生,也可选择selectdValueCommited事件，该事件在选择
        ///下拉列表关闭时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_scrapName_SelectedValueChanged(object sender, EventArgs e)
        {
            getCoefficiet();
        }

        /// <summary>
        /// 客户变更时，重计获取结算系数与重新计算结余金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_custName_SelectedValueChanged(object sender, EventArgs e)
        {
            var i = cmb_custName.SelectedValue;
            getCoefficiet();
            balance();
        }

        /// <summary>
        /// 离开焦点时计算结算单价与结算金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_webUnitPrice_Leave(object sender, EventArgs e)
        {
            caculateSettleUnitPrice();
            caculateMoney();

        }

        /// <summary>
        /// 离开焦点时计算结算金额
        /// 不使用textChanged事件，因为该事件每录入一个字符则会触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_netWeight_Leave(object sender, EventArgs e)
        {

            caculateMoney();
        }


        /// <summary>
        /// 结算金额一变更，则重新计算结余金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_money_TextChanged(object sender, EventArgs e)
        {
            balance();
        }

        /// <summary>
        /// 结算系数变更后重新计算结算单价与结算金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_coefficient_TextChanged(object sender, EventArgs e)
        {
            caculateSettleUnitPrice();
            caculateMoney();
        }

        #endregion


        #region 界面计算逻辑

        /// <summary>
        /// 获取结算系数
        /// </summary>
        private void getCoefficiet()
        {
            try
            {

                txt_coefficient.Text = new CoefficientService().coefficients().
                     Where(q => q.CustomerID.ToString() == cmb_custName.SelectedValue.ToString() & q.ScrapID.ToString() == cmb_scrapName.SelectedValue.ToString()).

                    Select(s => s.Data).ToList().FirstOrDefault().ToString();
            }

            ////当cmb_scrapNaem的值为NULL时
            catch (Exception)
            {
                txt_coefficient.Text = "";
            }

        }

        /// <summary>
        /// 计算结算金额
        /// </summary>
        private void caculateMoney()
        {
            if (txt_settleUnitPrice.Text != "" & txt_netWeight.Text != "")
            {
                txt_money.Text = (Convert.ToDouble(txt_netWeight.Text) * Convert.ToDouble(txt_settleUnitPrice.Text) / 1000).ToString();
            }
        }

        /// <summary>
        /// 计算结余金额
        /// </summary>
        private void balance()
        {

            if (cmb_custName.Text != "")
            {

                var incomeMoney = new IncomeService().incomes().Where(w => w.CustormerID.ToString() == cmb_custName.SelectedValue.ToString()).Sum(i => i.Money);
                var amountOfPayout = new WeighingRegisterService().weighingSettlements().Where(w => w.CustmerCode.ToString() == cmb_custName.SelectedValue.ToString()).Sum(i => i.settleAmount);

                //注意判断txt_money.Text==""而不是判断txt_money.Text==null,否则三无运算会报错，
                //因为无法把""值转为double
                double settleAount = txt_money.Text == "" ? 0 : Convert.ToDouble(txt_money.Text);
                lbl_balance.Text = (incomeMoney - amountOfPayout - settleAount).ToString();


            }

        }

        /// <summary>
        /// 计算结算单价
        /// </summary>
        private void caculateSettleUnitPrice()
        {
            if (txt_coefficient.Text != "" & txt_webUnitPrice.Text != "")
            {
                txt_settleUnitPrice.Text = (Convert.ToDouble(txt_coefficient.Text) / 100 * Convert.ToDouble(txt_webUnitPrice.Text)).ToString();

            }
        }









        #endregion

   
    }
    }


