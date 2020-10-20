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
using System.Drawing.Printing;
using ScrapSettlement.Common;
namespace ScrapSettlement
{
    public partial class Frm_weighingSettltement : Form
    {
        public Frm_weighingSettltement()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(this.closeParent);
            initalizeControlState();

        }

        /// <summary>
        /// 初始化控件数据源
        /// </summary>
        private void initializeDatasource()
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

            //初始化车牌号档案
            cmb_vehicleBrand.DataSource = new VehicleBrandService().vehicleBrands().Where(w => w.CustomerID == Convert.ToInt32(cmb_custName.SelectedValue))
                                                .Select(s => s.VehicleBrandValue).ToList();


        }

        /// <summary>
        /// 初始化控件状态
        /// </summary>
        private void initalizeControlState()
        {
            pnl_query.Visible = false;
            this.tableLayoutPanel1.Enabled = false;
            txt_money.Enabled = false;
            txt_settleUnitPrice.Enabled = false;
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
            pnl_query.Visible = false;
            tsb_save.Enabled = true;
            txt_webUnitPrice.Text = "";
            txt_grossWeight.Text = "";
            txt_settleUnitPrice.Text = "";
            txt_money.Text = "";
            txt_tare.Text = "";
            this.lbl_vouchNoValue.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
            initializeDatasource();

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
                //查询时的过滤条件是日期，所以存储值若含时间信息则条件值与存储值比较产生的
                //结果非目标数据，如查询当时的数据，因为按日期存储时其默认的时间信息是0时0分0秒
                //而查询条年是>=当日与<=当时，其查询结果则会为无匹配数据
                //故只按日期存储
                w.WeighingDate = dtp_makeDate.Value.Date;
                w.CustmerCode = cmb_custName.SelectedValue.ToString();
                w.GrossWeght = Convert.ToDouble(txt_grossWeight.Text);
                    w.Tare = Convert.ToDouble(txt_tare.Text);
                w.netWeight = Convert.ToDouble(txt_grossWeight.Text);
                w.VehicleBrand = cmb_vehicleBrand.Text;
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

        /// <summary>
        /// 单据查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_query_Click(object sender, EventArgs e)
        {
            pnl_query.Visible = true;
            using (var db = new ScrapSettleContext())
            {
                var q = from w in db.WeighingSettlement
                            //where(w.vocherNO=="")
                        select new { w.vocherNO };
                //赋值时注意对类型q进行转换， 不能直接写成rtxt_voucherNO.Text = q
                rtxt_voucherNO.Text = q.FirstOrDefault().vocherNO;
                btn_query.PerformClick();
            }


        }
        #endregion

        #region 界面值变更事件处理方法
        /// <summary>
        /// 皮重变更后离开焦点计算净重
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_tare_Leave(object sender, EventArgs e)
        {
            if (txt_grossWeight.Text != "")
            {
                caculateNetWeight();
            }
        }

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
        /// 网络价格变更离开焦点时计算结算单价与结算金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_webUnitPrice_Leave(object sender, EventArgs e)
        {
            caculateSettleUnitPrice();
            caculateMoney();

        }

        /// <summary>
        /// 净重变更后离开焦点事件计算结算金额
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

        /// <summary>
        /// 毛重变更事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_grossWeight_Leave(object sender, EventArgs e)
        {
            if (txt_tare.Text != "")
            {
                caculateNetWeight();
            }
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
            if (txt_settleUnitPrice.Text != "" & txt_grossWeight.Text != "")
            {
                txt_money.Text = (Convert.ToDouble(txt_grossWeight.Text) * Convert.ToDouble(txt_settleUnitPrice.Text) / 1000).ToString();
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
                lbl_balance.Text = (incomeMoney - amountOfPayout - settleAount).ToString("C");


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

        private void caculateNetWeight()
        {
            txt_netWeight.Text =(Convert.ToInt32( txt_grossWeight.Text) - Convert.ToInt32(txt_tare.Text)).ToString();
        }








        #endregion

        #region 打印


        private void tsb_previewPrint_Click(object sender, EventArgs e)
        {

            
            printPreviewDialog1.Document = printDocument1;
            PrintPreviewDialogWindowState.MakePrintPreviewDialogMaximized(printPreviewDialog1);
            printPreviewDialog1.ShowDialog();
            
        }

        private void Tsb_print_Click(object sender, EventArgs e)
        {

            this.printPreviewDialog1.Show();
        }

        /// <summary>
        /// 传递打印数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int r = 40;//初始X坐标
            int c = 40;//初始Y坐标

            //Array array = new Array();

            Pen blackPen = new Pen(Color.Black, 3);
            for (int i = 0; i < 5; i++)
            {

                for (int j = 2; j < 5; j++)
                {
                    //使用事件数据类PrintPageEventArgs中的Graphics属性获取打印数据
                    Rectangle rectangle = new Rectangle(100 + i * 100, 100, 100, 50);

                    e.Graphics.DrawRectangle(blackPen, rectangle);
                    r = r + 300;//每读取一行中的一个单元格数据，X坐标右移300后再写第二个单元格

                }
                r = 40;// 每读取一行完毕，X坐标回到原处
                c += 20;//每读取一行完毕，Y坐标下移20后再写第二行数据


            }
            e.Graphics.DrawString(lbl_titel.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(200.0F, 15.0F));
            PointF point1 = new PointF(100.0F, 50.0F);
            PointF point2 = new PointF(500.0F, 50.0F);

            // Draw line to screen.
            e.Graphics.DrawLine(blackPen, point1, point2);


            float x1 = 100.0F;
            float y1 = 100.0F;
            float x2 = 500.0F;
            float y2 = 100.0F;

            // Draw line to screen.
            e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);
            e.Graphics.DrawString(txt_grossWeight.Text, new Font("宋体", 10, FontStyle.Regular), Brushes.Black, r, c+40);
            r+=300    ; c += 40;
            e.Graphics.DrawString(txt_money.Text, new Font("宋体", 10, FontStyle.Regular), Brushes.Black, r, c);
            r += 300; c += 40;
            e.Graphics.DrawString(txt_coefficient.Text, new Font("宋体", 10, FontStyle.Regular), Brushes.Black, r, c);
            r += 300; c += 40;
            e.Graphics.DrawString(cmb_custName.Text, new Font("宋体", 10, FontStyle.Regular), Brushes.Black, r, c);
            r += 300; c += 40;
            e.Graphics.DrawString(cmb_scrapName.Text, new Font("宋体", 10, FontStyle.Regular), Brushes.Black, r, c);
            r += 300;
            r = 40;// 每读取一行完毕，X坐标回到原处
            c += 20;//每读取一行完毕，Y坐标下移20后再写第二行数据

          

            // Draw rectangles to screen.

          

            
        }

        #endregion

        #region 快捷键

        /// <summary>
        /// 回车代替TAB键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_weighingSettltement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Convert.ToInt32(e.KeyChar) == 13)
            {
                System.Windows.Forms.SendKeys.Send("{tab}");
            }
        }

        #endregion

        /// <summary>
        /// 一张单据查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Enabled = false;
            lbl_balance.Text = "";
            using (var db = new ScrapSettleContext())
            {
                var query = from q in db.WeighingSettlement
                            join c in db.Customers
                            on q.CustmerCode equals c.CusCode.ToString()
                            join p in db.Peple on q.personCode equals p.Code.ToString()
                            join s in db.Scraps on q.scrapCode equals s.ScrapCode.ToString()

                            where q.vocherNO == rtxt_voucherNO.Text

                            select new { q.WeighingDate, q.vocherNO, c.CusCode, c.CusName, s.ScrapID, s.ScrapName, q.proportion, q.webUnitPrice, q.settleUnitPrice, q.netWeight, q.settleAmount };
                foreach (var item in query)
                {
                    lbl_vouchNoValue.Text = item.vocherNO;
                    cmb_custName.SelectedValue = item.CusCode;
                    cmb_custName.Text = item.CusName;

                    cmb_scrapName.SelectedValue = item.ScrapID;
                    cmb_scrapName.Text = item.ScrapName;
                    txt_coefficient.Text = item.proportion.ToString();
                    txt_grossWeight.Text = item.netWeight.ToString();
                    txt_webUnitPrice.Text = item.webUnitPrice.ToString();
                    txt_settleUnitPrice.Text = item.settleUnitPrice.ToString();
                    //因为结算金额文本框定义了textChanged事件，所以定义查询时也触发该事件
                    //而去计算余额，虽然禁止了tableLayoutPanel,但无法禁止该事件，所以需要对
                    //事件委托解绑
                    txt_money.TextChanged -= this.txt_money_TextChanged;
                    // 
                    txt_money.Text = item.settleAmount.ToString();

                }
            }
        }

        private void Frm_weighingSettltement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.S & e.Control)
            {
                tsb_save.PerformClick();
            }
        }
    }
}


