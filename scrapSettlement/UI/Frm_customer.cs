
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using ScrapSettlement.DAL;
using System.Collections.Generic;

namespace ScrapSettlement.UI
{
    public partial class Frm_customer : Form
    {
        public Frm_customer()
        {
            InitializeComponent();
            this.initialize();

        }

        List<Customer> customerList = new List<Customer>();
        /// <summary>
        /// 初始化控件
        /// </summary>
        private void initialize()
        {
            this.FormClosed += new FormClosedEventHandler(this.closeParent);

                                   this.tsb_save.Enabled = false;
            this.tsb_modify.Enabled = false;
            this.dataGridView1.AutoGenerateColumns = false;
            

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

        /// <summary>
        /// 新增档案并自动生成客户编号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_add_Click(object sender, EventArgs e)
        {
            this.tsb_save.Enabled = true;
            //先清空查询时绑定的数据
            this.dataGridView1.DataSource = null;
            foreach (Control item in this.tableLayoutPanel1.Controls)
            {
               
                if (item.Name.Substring(0,3)=="txt")
                {
                    item.Text = null;
                }
                
               
            }
            //清空自定义控件中文本控件的值
            this.tbd_failure.Controls[1].Text = null;
            //赋值给dateTimePicker控件赋值，以其获取
            this.tbd_effect.Controls[0].Text = DateTime.Now.ToString();

            //取最大编号时速度太慢，三秒左右，同时最大号算法有误，取到第10号则不向上递增了。
            //using (var db = new WeighingSettlementModelContainer())
            //{
            //    Customer customer = new Customer();

            //    var custQuery = from cust in db.CustomerSet.AsNoTracking()

            //                    select cust.cusCode;
            //    maxCusCode = Convert.ToInt32(custQuery.Max()) + 1;


            //}
            //this.txt_cusCode.Text = maxCusCode.ToString();

            this.txt_cusCode.Focus();
        }

        /// <summary>
        /// 保存客户档案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_save_Click(object sender, EventArgs e)
        {


            using (var db = new WeighingSettlementModelContainer())
            {

                Customer customer = new Customer();
                customer.cusCode = this.txt_cusCode.Text;
                customer.cusName = this.txt_cusName.Text;
                customer.effectDate = Convert.ToDateTime(this.tbd_effect.Text);
                if (this.tbd_failure.Text != null)
                {
                    customer.failuerDate = Convert.ToDateTime(this.tbd_failure.Text);
                }


                db.CustomerSet.Add(customer);
                db.SaveChanges();
                                                customerList.Add(customer);
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = customerList;
                //MessageBox.Show("数据保存成功", "保存提示");
                //this.bind_gv_dateSource();

                //清空填制记录
                this.txt_cusCode.Text = null;
                this.txt_cusName.Text = null;

                //再次调用新增事件
                this.tsb_add.Click += this.Tsb_add_Click;
            }
        }



        /// <summary>
        /// 绑定dataGridView的数据源
        /// </summary>
        private void bind_gv_dateSource()
        {

            //使用EF速度很慢
            //this.dataGridView1.DataSource = new WeighingSettlementModelContainer().CustomerSet.ToList<Customer>();

            CustomerService customerService = new CustomerService();
           customerList= customerService.getCustomerList();
            this.dataGridView1.DataSource = customerList;

        }

      

        private void tsb_query_Click(object sender, EventArgs e)
        {
            this.tsb_save.Enabled = false;
            this.bind_gv_dateSource();
            this.tsb_modify.Enabled = true;
        }

        /// <summary>
        /// 选择当前行数据进行处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          

            if (e.RowIndex > -1)
            {
                this.txt_cusCode.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txt_cusName.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.tbd_effect.Controls[0].Text = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                //if (this.dataGridView1.Rows[e.RowIndex].Cells[3].Value != null)
                //{
                //    this.tbd_failure.Enabled = Enabled;
                    this.tbd_failure.Controls[0].Text = Convert.ToString(this.dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                //}

            }




        }
    }
}
