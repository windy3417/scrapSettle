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
using ScrapSettlement.Properties;
using scrapSettlement.Properties;

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

        #region 变量或枚举

        //新增后保存与修改后保存枚举值
        enum addOrChangeMolde
        {
            add,
            change,
            query

        }

        //新增修改标记

        string addOrChangeFlag;

        #endregion

        #region 初始化操作

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

            //string test = cmb_custName.SelectedValue.ToString();


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
            tsb_save.Enabled = false;
            tsb_modify.Enabled = false;
            tsb_delete.Enabled = false;
            tsb_abandon.Enabled = false;
            tsb_previewPrint.Enabled = false;
            tsb_print.Enabled = false;

            pnl_query.Visible = false;
            this.tableLayoutPanel1.Enabled = false;
            txt_money.Enabled = false;
            txt_settleUnitPrice.Enabled = false;
        }
        #endregion

        #region 窗体操作

        private void Tsb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeParent(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

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

        #endregion

        #region 单据增删改查

        /// <summary>
        /// 新增单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_new_Click(object sender, EventArgs e)
        {
            //调整事件触发状态
            //该事件查询时已经解绑
            if (addOrChangeFlag==addOrChangeMolde.query.ToString())
            {
                cmb_custName.SelectedValueChanged += cmb_custName_SelectedValueChanged;
            }
            
            
            //设定控件与变量状态
            tableLayoutPanel1.Enabled = true;
            pnl_query.Visible = false;
            tsb_save.Enabled = true;
            tsb_abandon.Enabled = true;
            tsb_query.Enabled = false;
            tsb_print.Enabled = false;
            tsb_previewPrint.Enabled = false;
            tsb_modify.Enabled = false;
            //调整单据修改时的控件状态
            if (addOrChangeFlag == addOrChangeMolde.change.ToString())
            {
                dtp_makeDate.Enabled = true;
                cmb_custName.Enabled = true;
                cmb_scrapName.Enabled = true;
                cmb_person.Enabled = true;
                cmb_vehicleBrand.Enabled = true;
                txt_grossWeight.Enabled = true;
                txt_tare.Enabled = true;
                txt_weighingTime.Enabled = true;

            }
            addOrChangeFlag = addOrChangeMolde.add.ToString();

            //清空已填制的数据
            txt_webUnitPrice.Text = "";
            txt_grossWeight.Text = "";
            txt_settleUnitPrice.Text = "";
            txt_money.Text = "";
            txt_tare.Text = "";
            dtp_makeDate.Value = DateTime.Now;
            txt_weighingTime.Text = DateTime.Now.ToLongTimeString();
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
            if (addOrChangeFlag == addOrChangeMolde.add.ToString())
            {
                using (var db = new ScrapSettleContext())
                {
                    WeighingSettlement w = new WeighingSettlement();
                    saveData(db, w);

                }
            }
            if (addOrChangeFlag == addOrChangeMolde.change.ToString())
            {
                using (var db = new ScrapSettleContext())
                {
                    WeighingSettlement w = db.WeighingSettlement.Where(s => s.vocherNO == lbl_vouchNoValue.Text).FirstOrDefault();
                    saveData(db, w);
                }
            }

        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="db"></param>
        /// <param name="w"></param>
        private void saveData(ScrapSettleContext db, WeighingSettlement w)
        {

            //查询时的过滤条件是日期，所以存储值若含时间信息则条件值与存储值比较产生的
            //结果非目标数据，如查询当时的数据，因为按日期存储时其默认的时间信息是0时0分0秒
            //而查询条年是>=当日与<=当时，其查询结果则会为无匹配数据
            //故只按日期存储


            //修改数据保存准备
            if (addOrChangeFlag == addOrChangeMolde.change.ToString())
            {
                w.webUnitPrice = Convert.ToDouble(txt_webUnitPrice.Text);
                w.settleUnitPrice = Convert.ToDouble(txt_settleUnitPrice.Text);
                w.settleAmount = Convert.ToDouble(txt_money.Text);
            }

            //新增数据保存准备
            if (addOrChangeFlag == addOrChangeMolde.add.ToString())
            {

                w.MakeDate = DateTime.Now;
                w.WeighingDate = dtp_makeDate.Value.Date;
                w.WeightingTime = dtp_makeDate.Value.ToLongTimeString();
                w.CustmerCode = cmb_custName.SelectedValue.ToString();
                w.GrossWeght = Convert.ToDouble(txt_grossWeight.Text);
                w.Tare = Convert.ToDouble(txt_tare.Text);
                w.netWeight = Convert.ToDouble(txt_netWeight.Text);
                w.VehicleBrand = cmb_vehicleBrand.Text;
                w.personCode = cmb_person.SelectedValue.ToString();
                w.proportion = Convert.ToDouble(txt_coefficient.Text);
                w.scrapCode = cmb_scrapName.SelectedValue.ToString();
                w.vocherNO = lbl_vouchNoValue.Text;
                //考虑到价格信息由业务经办人填写，而非由过磅人填写，故可为空
                //w.webUnitPrice = Convert.ToDouble(txt_webUnitPrice.Text);
                //w.settleUnitPrice = Convert.ToDouble(txt_settleUnitPrice.Text);
                //w.settleAmount = Convert.ToDouble(txt_money.Text);
                w.webUnitPrice = txt_webUnitPrice.Text == "" ? 0 : Convert.ToDouble(txt_webUnitPrice.Text);
                w.settleUnitPrice = txt_settleUnitPrice.Text == "" ? 0 : Convert.ToDouble(txt_settleUnitPrice.Text);
                w.settleAmount = txt_money.Text == "" ? 0 : Convert.ToDouble(txt_money.Text);
                db.WeighingSettlement.Add(w);
            }


            //数据保存
            try
            {
                db.SaveChanges();
                tsb_save.Enabled = false;
                tsb_print.Enabled = true;
                tsb_previewPrint.Enabled = true;
                tableLayoutPanel1.Enabled = false;
                if (addOrChangeFlag == addOrChangeMolde.change.ToString())
                {
                    tsb_new.Enabled = true;

                }
                if (addOrChangeFlag == addOrChangeMolde.add.ToString())
                {
                    tsb_modify.Enabled = true;
                    tsb_delete.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException, "保存错误提示");
            }
        }

        /// <summary>
        /// 单据修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_modify_Click(object sender, EventArgs e)
        {
            //修改时则启用余额计算功能
            txt_money.TextChanged += this.txt_money_TextChanged;

            addOrChangeFlag = addOrChangeMolde.change.ToString();
            //改变控件状态
            tsb_abandon.Enabled = true;
            tsb_new.Enabled = false;
            tsb_save.Enabled = true;
            tableLayoutPanel1.Enabled = true;
            //限定可修改范围，只能修改价格信息
            dtp_makeDate.Enabled = false;
            cmb_custName.Enabled = false;
            cmb_scrapName.Enabled = false;
            cmb_person.Enabled = false;
            cmb_vehicleBrand.Enabled = false;
            txt_grossWeight.Enabled = false;
            txt_tare.Enabled = false;
            txt_weighingTime.Enabled = false;


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
                        //where (w.vocherNO.Max())
                        select new {  w.vocherNO };
                //赋值时注意对类型q进行转换， 不能直接写成rtxt_voucherNO.Text = q
                rtxt_voucherNO.Text = (q.Select(s => s.vocherNO)).Max().ToString();
                btn_query.PerformClick();
                tsb_previewPrint.Enabled = true;
                tsb_print.Enabled = true;
            }


        }

        /// <summary>
        /// 一张单据查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_Click(object sender, EventArgs e)
        {
            //因为结算金额文本框定义了textChanged事件，所以定义查询时也触发该事件
            //而去计算余额，虽然禁止了tableLayoutPanel,但无法禁止该事件，所以需要对
            //事件委托解绑
            cmb_custName.SelectedValueChanged -= cmb_custName_SelectedValueChanged;

            txt_money.TextChanged -= this.txt_money_TextChanged;
            addOrChangeFlag = addOrChangeMolde.query.ToString();

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

                            select new
                            {
                                q.WeighingDate,
                                q.WeightingTime,
                                q.vocherNO,
                                c.CusCode,
                                c.CusName,
                                s.ScrapID,
                                s.ScrapName,
                                p.Code,
                                p.Name,
                                q.VehicleBrand,
                                q.proportion,
                                q.webUnitPrice,
                                q.settleUnitPrice,
                                q.GrossWeght,
                                q.Tare,
                                q.netWeight,
                                q.settleAmount
                            };
                foreach (var item in query)
                {
                    lbl_vouchNoValue.Text = item.vocherNO;
                    //如果查询有结果，则启用修改菜单与删除菜单
                    if (lbl_vouchNoValue.Text != "" & lbl_vouchNoValue.Text != null)
                    {
                        tsb_modify.Enabled = Enabled;
                        tsb_delete.Enabled = Enabled;
                    }


                    //实践表明，不初始化combox控件的数据源，则无法对SelectedValue进行赋值
                    //因为赋值后赋值等式右边虽然有值，但SelectedValue确仍为空，具体什么原因不明？
                    initializeDatasource();

                    dtp_makeDate.Text = item.WeighingDate.ToString();
                    txt_weighingTime.Text = item.WeightingTime;

                    cmb_custName.SelectedValue = item.CusCode.ToString();
                    cmb_custName.Text = item.CusName;

                    cmb_scrapName.SelectedValue = item.ScrapID;
                    cmb_scrapName.Text = item.ScrapName;

                    cmb_person.SelectedValue = item.Code;
                    cmb_person.Text = item.Name;

                    cmb_vehicleBrand.Text = item.VehicleBrand;
                    txt_coefficient.Text = item.proportion.ToString();
                    txt_grossWeight.Text = item.GrossWeght.ToString();
                    txt_tare.Text = item.Tare.ToString();
                    txt_netWeight.Text = item.netWeight.ToString();

                    txt_webUnitPrice.Text = item.webUnitPrice.ToString();
                    txt_settleUnitPrice.Text = item.settleUnitPrice.ToString();
                    txt_money.Text = item.settleAmount.ToString();

                                     



                }
            }
        }

        /// <summary>
        /// 删除单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_delete_Click(object sender, EventArgs e)
        {
            if (lbl_vouchNoValue.Text != "" & lbl_vouchNoValue.Text != null)
            {
                if (DialogResult.Yes == MessageBox.Show("是否确定删除", "删除提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    try
                    {
                        using (var db = new ScrapSettleContext())
                        {
                            var del = (from d in db.WeighingSettlement
                                       where (d.vocherNO == lbl_vouchNoValue.Text)
                                       select d).ToList(); ;
                            //移除数据库的数据
                            db.WeighingSettlement.Remove(del[0]);
                            db.SaveChanges();
                            clearDate();
                            lbl_vouchNoValue.Text = "";
                            dtp_makeDate.Text = "";
                            rtxt_voucherNO.Text = "";
                            //修改单据功能状态
                            tsb_delete.Enabled = false;
                            tsb_modify.Enabled = false;
                            tsb_previewPrint.Enabled = false;
                            tsb_print.Enabled = false;

                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("数据删除出错" + ex.Message + ex.InnerException, "数据删除提示");
                    }
                }

            }







        }

        /// <summary>
        /// 放弃新增与修改的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_abandon_Click(object sender, EventArgs e)
        {
            //if (addOrChangeFlag==addOrChangeMolde.add.ToString())
            //{

            //    tsb_save.Enabled = false;

            //}
            if (addOrChangeFlag == addOrChangeMolde.change.ToString())
            {
                tsb_modify.Enabled = false;

            }
            clearDate();
            tsb_save.Enabled = false;
            lbl_balance.Text = "";
            tsb_abandon.Enabled = false;
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

            if (cmb_custName.SelectedValue != null & cmb_custName.Text != "")
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
            txt_netWeight.Text = (Convert.ToInt32(txt_grossWeight.Text) - Convert.ToInt32(txt_tare.Text)).ToString();
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
            printDialog1.Document = printDocument1;
            printDialog1.AllowSomePages = true;

            DialogResult result = printDialog1.ShowDialog();

            // If the result is OK then print the document.
            //打印预览时只要printPreviewDialog1.Document = printDocument1关联后就可的打印
            //直接打印则需要调用PrintDocumnt.Print()方可打印，否按在对话框中点【打印】但不会有反应
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        /// <summary>
        /// 传递打印数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            //初始纵向距离后,根据文字占位即时更新
            int y = 50;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            //logo
            e.Graphics.DrawImage(Resources.logo, new Rectangle(100, y, 150, 40));


            //标题
            e.Graphics.DrawString(lbl_titel.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(330, y));
            //单据编号
            e.Graphics.DrawString("单据编号：", new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 525, y + 50);
            e.Graphics.DrawString(lbl_vouchNoValue.Text, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(600, y + 50));


            //单据联次
            Rectangle rectangleCopy = new Rectangle(720, y + 135, 20, 100);
            e.Graphics.DrawString("第一联：记账联", new Font(DefaultFont, FontStyle.Bold), Brushes.Black, rectangleCopy, stringFormat);

            //更新纵坐标
            y = y + 10;
            Pen blackpenContent = new Pen(Color.Black, 1);



            //待打印数据集
            String[] head = new string[8] { "过磅日期", "时间", "客户名称", "车牌号码", "货物名称", "毛重(KG)", "皮重(KG)", "净重(KG)" };
            string[] content = new string[8] {  dtp_makeDate.Value.Date.ToString("yyyy-MM-dd"),txt_weighingTime.Text,
                                                cmb_custName.Text, cmb_vehicleBrand.Text,cmb_scrapName.Text, txt_grossWeight.Text, txt_tare.Text,
                                                txt_netWeight.Text };


            for (int i = 0; i < head.Count(); i++)
            {


                //使用事件数据类PrintPageEventArgs中Graphics属性获取打印数据

                //打印表头

                Rectangle rectangleHead = new Rectangle(100, y + 70 + i * 30, 100, 30);


                e.Graphics.DrawRectangle(blackpenContent, rectangleHead);
                e.Graphics.DrawString(head[i], new Font(DefaultFont, FontStyle.Bold), Brushes.Black, rectangleHead, stringFormat);

                //打印内容
                Rectangle rectangleContent = new Rectangle(200, y + 70 + i * 30, 500, 30);
                e.Graphics.DrawRectangle(blackpenContent, rectangleContent);
                e.Graphics.DrawString(content[i], DefaultFont, Brushes.Black, rectangleContent, stringFormat);



            }

            y = y + 70 + head.Count() * 30;

            //打印签名
            e.Graphics.DrawString("监磅人：", new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 120, y + 30);
            e.Graphics.DrawString("经办人：", new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 120, y + 60);
            e.Graphics.DrawString("预付款余额：", new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 520, y + 30);
            e.Graphics.DrawString("销售单位盖章：", new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 520, y + 60);



            y = y + 300;

            // Draw line to screen.
            //Pen blackPenLine = new Pen(Color.Black, 1);
            //Point point1 = new Point(50, y + 100);
            //Point point2 = new Point(750, y + 100);

            //e.Graphics.DrawLine(blackPenLine, point1, point2);


            //重复打印
            //logo
            e.Graphics.DrawImage(Resources.logo, new Rectangle(100, y, 150, 40));
            //标题
            e.Graphics.DrawString(lbl_titel.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(330, y));
            //单据编号
            e.Graphics.DrawString("单据编号：", new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 525, y + 50);
            e.Graphics.DrawString(lbl_vouchNoValue.Text, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(600, y + 50));


            //单据联次
            Rectangle rectangleCopy2 = new Rectangle(720, y + 135, 20, 100);
            e.Graphics.DrawString("第二联：结算联", new Font(DefaultFont, FontStyle.Bold), Brushes.Black, rectangleCopy2, stringFormat);

            //更新纵坐标
            y = y + 10;



            for (int i = 0; i < head.Count(); i++)
            {


                //使用事件数据类PrintPageEventArgs中Graphics属性获取打印数据

                //打印表头

                Rectangle rectangleHead = new Rectangle(100, y + 70 + i * 30, 100, 30);


                e.Graphics.DrawRectangle(blackpenContent, rectangleHead);
                e.Graphics.DrawString(head[i], new Font(DefaultFont, FontStyle.Bold), Brushes.Black, rectangleHead, stringFormat);

                //打印内容
                Rectangle rectangleContent = new Rectangle(200, y + 70 + i * 30, 500, 30);
                e.Graphics.DrawRectangle(blackpenContent, rectangleContent);
                e.Graphics.DrawString(content[i], DefaultFont, Brushes.Black, rectangleContent, stringFormat);



            }

            y = y + 70 + head.Count() * 30;

            //打印签名
            e.Graphics.DrawString("监磅人：", new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 120, y + 30);
            e.Graphics.DrawString("经办人：", new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 120, y + 60);
            e.Graphics.DrawString("预付款余额：", new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 520, y + 30);
            e.Graphics.DrawString("销售单位盖章：", new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 520, y + 60);














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


        private void Frm_weighingSettltement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S & e.Control)
            {
                tsb_save.PerformClick();
            }
        }






        #endregion

    
    }
}


