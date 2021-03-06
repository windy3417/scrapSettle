﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility;
using Utility.UI;
using ScrapSettlement.UI;
using System.Configuration;

namespace ScrapSettlement
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.initialize();
        }


        #region 菜单事件处理

        private void 结算系数调整单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_coefficient frm_Coefficient = new Frm_coefficient();
            string tabPageText = frm_Coefficient.Text;
            EmbedForm embedForm = new EmbedForm();
            embedForm.openForm(frm_Coefficient, tabPageText, tabControl1, panel1);
        }

        private void 收入登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_income frm_income = new Frm_income();
            string tabPageText = frm_income.Text;
            EmbedForm embedForm = new EmbedForm();
            embedForm.openForm(frm_income, tabPageText, tabControl1, panel1);
        }

        private void 收款单列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_incomeList frm_incomeList = new Frm_incomeList();
            string tabPageText = frm_incomeList.Text;
            EmbedForm embedForm = new EmbedForm();
            embedForm.openForm(frm_incomeList, tabPageText, tabControl1, panel1);
        }

        private void 过磅单列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_weighingList frm_weighingList = new Frm_weighingList();
            string tabPageText = frm_weighingList.Text;
            EmbedForm embedForm = new EmbedForm();
            embedForm.openForm(frm_weighingList, tabPageText, tabControl1, panel1);
        }

        private void 车牌档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_vehicleBrand v = new Frm_vehicleBrand();
            string tabPageText = v.Text;
            EmbedForm embedForm = new EmbedForm();
            embedForm.openForm(v, tabPageText, tabControl1, panel1);
        }

        private void 过磅登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_weighingSettltement w = new Frm_weighingSettltement();
            string tabPageText = w.Text;
            EmbedForm embedForm = new EmbedForm();
            embedForm.openForm(w, tabPageText, tabControl1, panel1);

        }

        private void 客户档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_customer frm_Customer = new Frm_customer();
            string tabPageText = frm_Customer.Text;
            EmbedForm embedForm = new EmbedForm();
            embedForm.openForm(frm_Customer, tabPageText, tabControl1, panel1);
        }

        private void 废料档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_scrapItem frm_Scrap = new Frm_scrapItem();
            string tabPageText = frm_Scrap.Text;
            EmbedForm embedForm = new EmbedForm();
            embedForm.openForm(frm_Scrap, tabPageText, tabControl1, panel1);

        }

        private void 数据库设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_config f = new Frm_config();
            string tabPageText = f.Text;
            EmbedForm embedForm = new EmbedForm();
            embedForm.openForm(f, tabPageText, tabControl1, panel1);
        }

        private void 经办人档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_person frm_person = new Frm_person();
            string tabPageText = frm_person.Text;
            EmbedForm embedForm = new EmbedForm();
            embedForm.openForm(frm_person, tabPageText, tabControl1, panel1);
        }

        #endregion


        private void initialize()
        {
            if (ConfigurationManager.ConnectionStrings["business"] == null)
            {
                Frm_config frm_Config = new Frm_config();
                string tabPageText = frm_Config.Text;
                Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
                embed.openForm(frm_Config, tabPageText, tabControl1, panel1);
            }
        }

     

    }
}
