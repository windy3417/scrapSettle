using ScrapSettlement.DAL;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;

namespace ScrapSettlement.UI
{
    public partial class Frm_customer : Form
    {
        public Frm_customer()
        {
            InitializeComponent();
            this.initialize();

        }

        private void initialize()
        {
            this.FormClosed += new FormClosedEventHandler(this.closeParent);
            this.tbd_effect.Controls[0].Text = DateTime.Now.ToString();
            this.tableLayoutPanel1.Enabled = false;
            
            this.bind_gv_dateSource();

        }

        private void txt_cusCode_Validating(object sender, CancelEventArgs e)
        {
            string pattern = "^-?[1-9]\\d*$";
            Regex regex = new Regex(pattern);
            if (!regex.Match(txt_cusCode.Text).Success)
            {

                //为空时不做正则判断
                if (this.txt_cusCode.TextLength == 0)
                {
                    return;
                }
                else
                {
                    MessageBox.Show("请输入数字作为编码", "输入验证", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_cusCode.Text = "";
                    this.txt_cusCode.Focus();
                }


            };
        }

        private void Tsb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeParent(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void Tsb_save_Click(object sender, EventArgs e)
        {


            using (var db = new WeighingSettlementModelContainer())
            {

                Customer customers = new Customer();
                customers.cusCode = this.txt_cusCode.Text;
                customers.cusName = this.tex_cusName.Text;
                customers.effectDate = Convert.ToDateTime(this.tbd_effect.Text);
                if (this.tbd_failure.Text != null)
                {
                    customers.failuerDate = Convert.ToDateTime(this.tbd_failure.Text);
                }


                db.CustomerSet.Add(customers);
                db.SaveChanges();
                
                //MessageBox.Show("数据保存成功", "保存提示");
                this.bind_gv_dateSource();

                //清空填制记录
                this.txt_cusCode.Text = null;
                this.tex_cusName.Text = null;

                //再次调用新增事件
                this.tsb_add.Click += this.Tsb_add_Click;
            }
        }

        /// <summary>
        /// 新增档案并自动生成客户编号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_add_Click(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.Enabled = true;
            using (var db = new WeighingSettlementModelContainer())
            {
                Customer customer = new Customer();

                var custQuery = from cust in db.CustomerSet.AsNoTracking()

                                select cust.cusCode;
                int cusCode = Convert.ToInt32(custQuery.Max()) + 1;
                this.txt_cusCode.Text = cusCode.ToString();

                this.tex_cusName.Focus();


            }
        }

        /// <summary>
        /// 绑定dataGridView的数据源
        /// </summary>
        private void bind_gv_dateSource()
        {
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = new WeighingSettlementModelContainer().CustomerSet.ToList<Customer>();

        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
