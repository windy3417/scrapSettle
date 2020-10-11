
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
    public partial class Frm_coefficient : Form
    {
        public Frm_coefficient()
        {
            InitializeComponent();
            this.initialize();

        }

        #region 变量
        //新增时,dataGridview绑定的数据源，以体现新增的结果
        List<Coefficient> archivesList = new List<Coefficient>();


        //dataGridView控件的数据来源，true为查询时绑定，
        //false为新增档案时的绑定

        enum saveOrChangeOrQueryMolde
        {
            save,
            change,
            query
        }

        //修改与新增的dbContext标记,true为新增dbContext，false为修改dbContext

        bool saveOrChangeFlag = true;
        string saveOrModifQueryFlag;
        #endregion


        /// <summary>
        /// 初始化控件及数据源
        /// </summary>
        private void initialize()
        {
            this.FormClosed += new FormClosedEventHandler(this.closeParent);

            this.tsb_save.Enabled = false;
            this.tsb_modify.Enabled = false;
            this.tsb_delete.Enabled = false;
            tsb_abandon.Enabled = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.tableLayoutPanel1.Enabled = false;
            lbl_voucherStatus.Visible = false;
            //初始化客户名称数据源
            BindingSource bindingSourceForCusName = new BindingSource();
            bindingSourceForCusName.DataSource = new CustomerService().getCustomerList().Where<Customer>(c => c.FailuerDate == null).Select((c) => new { c.CusCode, c.CusName }).ToList();

            cmb_cusName.DataSource = bindingSourceForCusName;
            cmb_cusName.DisplayMember = "CusName";
            cmb_cusName.ValueMember = "CusCode";
            //初始化废料档案数据源

            cmb_scrapName.DataSource = new ScrapService().scrapList().Select(s => new { s.ScrapCode, s.ScrapName }).ToList();
            cmb_scrapName.DisplayMember = "ScrapName";
            cmb_scrapName.ValueMember = "ScrapCode";





        }

        #region 增删改查

        /// <summary>
        /// 新增单据并自动生成单据编号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_add_Click(object sender, EventArgs e)
        {

            this.tableLayoutPanel1.Enabled = true;
            //按日期单据号会有重复，暂按时间
            //this.lbl_vouchNoValue.Text = DateTime.Now.ToString("yyyyMMdd");
            this.lbl_vouchNoValue.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
            lbl_voucherStatus.Text = "单据状态：新增";
            lbl_voucherStatus.Visible = true;

            //先清空查询时绑定的数据
            clearDate();
            //故增加数据源判定,否则连续增加时就无法在DataGridView中显示增加的记录
            if (saveOrModifQueryFlag != saveOrChangeOrQueryMolde.save.ToString())
            {
                saveOrModifQueryFlag = saveOrChangeOrQueryMolde.save.ToString();
                this.dataGridView1.DataSource = null;
            }

            this.tsb_save.Enabled = true;
            tsb_abandon.Enabled = true;

            //新增与查询功能中的dataGridView数据源不同，且该数据源标记通过功能键触发选择
            //tsb_query.Enabled = false;
            tsb_modify.Enabled = false;
            this.tableLayoutPanel1.Enabled = true;


            //给自定义日期控件赋值，其中的textBox控件为显示值
            //日期控件的文本为将需要存储的值
            this.tbd_effect.Controls[2].Text = DateTime.Now.ToString().Substring(0, 10);
            tbd_effect.Text = DateTime.Now.ToString().Substring(0, 10);



        }


        /// <summary>
        /// 删除选择定行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_delete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                string selected = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                if (DialogResult.Yes == MessageBox.Show("是否确定删除", "删除提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {

                    ScrapSettleContext db = new ScrapSettleContext();

                    List<Coefficient> del = (from d in db.Coefficients
                                             where d.VoucherNO == selected
                                             select d).ToList<Coefficient>();
                    //移除数据库的数据
                    db.Coefficients.Remove(del[0]);
                    db.SaveChanges();
                    clearDate();

                    //如果是在新增界面状态使用删除功能，则同时删除内存中的集合数据
                    //数据库中的条件实体delCustomer不能成为内存中的待删除实体
                    //即：customerList.Remove(delCustomer[0])返回false,故无法实现
                    //内存当中的数据集记录删除;
                    if (saveOrModifQueryFlag == saveOrChangeOrQueryMolde.save.ToString())
                    {

                        List<Coefficient> coefficients = archivesList.Where(c => c.VoucherNO == selected).ToList<Coefficient>();
                        archivesList.Remove(coefficients[0]);

                    }
                    bind_gv_dateSource();
                }
            }

            return;

        }

        /// <summary>
        /// 保存单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_save_Click(object sender, EventArgs e)
        {

            saveOrChang();

        }

        /// <summary>
        /// 修改客户档案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_modify_Click(object sender, EventArgs e)
        {
            lbl_voucherStatus.Text = "档案状态：修改";
            lbl_voucherStatus.Visible = true;

            tableLayoutPanel1.Enabled = true;
            //编码不能被修改

            tsb_save.Enabled = true;

        }

        /// <summary>
        /// 查询单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_query_Click(object sender, EventArgs e)
        {
            clearDate();
            lbl_voucherStatus.Text = "单据状态：查询";
            lbl_voucherStatus.Visible = true;

            saveOrModifQueryFlag = saveOrChangeOrQueryMolde.query.ToString();
            this.tsb_save.Enabled = false;

            this.bind_gv_dateSource();

            this.tsb_modify.Enabled = true;

            this.tsb_delete.Enabled = true;
            if (dataGridView1.Rows.Count > 0)
            {
                this.dataGridView1.Rows[0].Selected = true;
            }


        }


        #endregion

        #region 输入校验

        /// <summary>
        /// 正则校验
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void regValidating(object sender, CancelEventArgs e)
        {
            string pattern = "^-?[1-9]\\d*$";
            Regex regex = new Regex(pattern);


        }

        /// <summary>
        /// 为空校验
        /// </summary>
        private bool inputVlidate()
        {

            for (int i = 0; i < this.tableLayoutPanel1.Controls.Count;)
            {
                //if (this.tableLayoutPanel1.Controls[i].Name.Substring(0, 3) == "txt" & this.tableLayoutPanel1.Controls[i].Text == "")
                if (this.tableLayoutPanel1.Controls[i].Name != tbd_failure.Name)
                {
                    if (this.tableLayoutPanel1.Controls[i].Text == "" || this.tableLayoutPanel1.Controls[i].Text == null)
                    {
                        MessageBox.Show(this.tableLayoutPanel1.Controls[i].Tag + "不能为空", "输入校验");
                        return false;
                    }
                }

                i++;


            }
            return true;


        }
        #endregion


        #region 窗体操作
        /// <summary>
        /// 关闭嵌入式窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 关闭母窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeParent(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        #endregion


        #region 数据处理与绑定
        /// <summary>
        /// 绑定dataGridView的数据源
        /// </summary>
        private void bind_gv_dateSource()
        {
            this.dataGridView1.DataSource = null;

            //查询状态的数据源
            if (saveOrModifQueryFlag == saveOrChangeOrQueryMolde.query.ToString())
            {
                using (var db = new ScrapSettleContext())
                {
                    var query = from q in db.Coefficients
                                join c in db.Customers
                                on q.CustomerID equals c.CusCode
                                join s in db.Scraps
                                on q.ScrapID equals s.ScrapCode
                                select new { q.VoucherNO, c.CusName, s.ScrapName, q.Data, q.EffectDate, q.FailureDate };
                    dataGridView1.DataSource = query.ToList();
                }
                
                
            }
            //新增状态的数据源
            else
            {
                this.dataGridView1.DataSource = archivesList;
            }




        }

        /// <summary>
        /// 清除录入与查询出的数据
        /// </summary>
        private void clearDate()
        {
            foreach (Control item in this.tableLayoutPanel1.Controls)
            {

                //if (item.Name.Substring(0, 3) != "lbl")
                if (item.GetType() != typeof(Label))
                {
                    item.Text = "";
                }



            }
        }

        /// <summary>
        /// 数据保存与修改
        /// </summary>
        private void saveOrChang()
        {

            if (inputVlidate())
            {
                //新增后保存
                if (saveOrModifQueryFlag == saveOrChangeOrQueryMolde.save.ToString())
                {
                    using (var db = new ScrapSettleContext())
                    {

                        
                        Coefficient coefficient = new Coefficient();
                        coefficient.VoucherNO = lbl_vouchNoValue.Text;
                        //注意组合框中的取值不是text属性，而是selectedValue
                        coefficient.CustomerID = Convert.ToInt32(cmb_cusName.SelectedValue);
                        coefficient.ScrapID = Convert.ToInt32(cmb_scrapName.SelectedValue);
                        coefficient.Data = Convert.ToDouble(txt_data.Text);
                        coefficient.EffectDate = Convert.ToDateTime(this.tbd_effect.Text);
                        if (this.tbd_failure.Text != null & tbd_failure.Text != "")
                        {
                            coefficient.FailureDate = Convert.ToDateTime(this.tbd_failure.Text);
                        }

                        
                        try
                        {
                            db.SaveChanges();
                            //内存数据源
                            archivesList.Add(coefficient);

                            var query = from q in archivesList
                                        join c in db.Customers
                                        on q.CustomerID equals c.CusCode
                                        join s in db.Scraps
                                        on q.ScrapID equals s.ScrapCode
                                        select new { q.VoucherNO, c.CusName,s.ScrapName,q.Data,q.EffectDate,q.FailureDate };
                            dataGridView1.DataSource = query.ToList();
                        }
                        catch (Exception e)
                        {

                            MessageBox.Show("数据保存错误:" + e.Message + e.InnerException, "数据保存提示");
                            return;
                        }

                                                                   
                      
                        clearDate();

                        //再次调用新增事件

                        this.tsb_add.PerformClick();
                    }
                }

                //查询之后修改并保存
                if (saveOrModifQueryFlag == saveOrChangeOrQueryMolde.query.ToString())
                {
                    using (var db = new ScrapSettleContext())
                    {

                        Coefficient coefficient = db.Coefficients.Where(c => c.VoucherNO.ToString() == lbl_vouchNoValue.Text).FirstOrDefault();

                        coefficient.CustomerID = Convert.ToInt32(cmb_cusName.SelectedValue);
                        coefficient.ScrapID = Convert.ToInt32(cmb_scrapName.SelectedValue);
                        coefficient.Data = Convert.ToDouble(txt_data.Text);
                        coefficient.EffectDate = Convert.ToDateTime(this.tbd_effect.Text);
                        if (this.tbd_failure.Text != null & tbd_failure.Text != "")
                        {
                            coefficient.FailureDate = Convert.ToDateTime(this.tbd_failure.Text);
                        }
                        try
                        {
                            db.SaveChanges();
                            this.bind_gv_dateSource();
                        }
                        catch (Exception e)
                        {
                            
                            MessageBox.Show("数据保存错误:" + e.Message + e.InnerException, "数据保存提示");
                            return;
                        }
                
                                                
                        //清空修改记录
                        clearDate();
                    }
                }
            };




        }

        /// <summary>
        /// 选择当前行数据进行处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            clearDate();
            if (e.RowIndex > -1)
            {
                lbl_vouchNoValue.Text= this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.cmb_cusName.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.cmb_scrapName.Text = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_data.Text= this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
              
                this.tbd_effect.Text = this.dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (this.dataGridView1.Rows[e.RowIndex].Cells[5].Value is null)
                {
                    return;
                }
                else
                {
                    tbd_failure.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
              

            }




        }

        #endregion


        #region 快捷键
        /// <summary>
        /// 回车代替TAB键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Convert.ToInt32(e.KeyChar) == 13)
            {
                System.Windows.Forms.SendKeys.Send("{tab}");
            }
        }

        /// <summary>
        /// 快捷键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_customer_KeyDown(object sender, KeyEventArgs e)
        {
            // if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
            if (e.KeyCode == Keys.S && e.Control)
            {
                tsb_save.PerformClick(); //执行单击button1的动作      
            }
            if (e.KeyCode == Keys.Delete)
            {
                tsb_delete.PerformClick();
            }

        }







        #endregion

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            tsb_delete.Enabled = true;
        }

        /// <summary>
        /// 放弃新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_abandon_Click(object sender, EventArgs e)
        {
            tsb_save.Enabled = false;
            tsb_modify.Enabled = false;
            tsb_delete.Enabled = false;
            tsb_query.Enabled = true;
            tsb_abandon.Enabled = false;

        }
    }
}