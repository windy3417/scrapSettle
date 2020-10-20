namespace ScrapSettlement
{
    partial class Frm_income

    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_income));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_vouchNo = new System.Windows.Forms.Label();
            this.horizonLine2 = new Utility.UControl.HorizonLine();
            this.horizonLine1 = new Utility.UControl.HorizonLine();
            this.dtp_make = new System.Windows.Forms.DateTimePicker();
            this.lbl_vouchNoValue = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_computeUnit = new System.Windows.Forms.Label();
            this.lbl_titel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_personCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_money = new System.Windows.Forms.TextBox();
            this.lbl_customerCode = new System.Windows.Forms.Label();
            this.cmb_custName = new System.Windows.Forms.ComboBox();
            this.dtp_income = new System.Windows.Forms.DateTimePicker();
            this.pnl_query = new System.Windows.Forms.Panel();
            this.btn_query = new System.Windows.Forms.Button();
            this.rtxt_voucherNO = new System.Windows.Forms.RichTextBox();
            this.ts_income = new System.Windows.Forms.ToolStrip();
            this.tsb_new = new System.Windows.Forms.ToolStripButton();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_query = new System.Windows.Forms.ToolStripButton();
            this.tsb_modify = new System.Windows.Forms.ToolStripButton();
            this.tsb_print = new System.Windows.Forms.ToolStripButton();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_query.SuspendLayout();
            this.ts_income.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl_vouchNo);
            this.panel1.Controls.Add(this.horizonLine2);
            this.panel1.Controls.Add(this.horizonLine1);
            this.panel1.Controls.Add(this.dtp_make);
            this.panel1.Controls.Add(this.lbl_vouchNoValue);
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbl_computeUnit);
            this.panel1.Controls.Add(this.lbl_titel);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.pnl_query);
            this.panel1.Location = new System.Drawing.Point(81, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 462);
            this.panel1.TabIndex = 6;
            // 
            // lbl_vouchNo
            // 
            this.lbl_vouchNo.AutoSize = true;
            this.lbl_vouchNo.Location = new System.Drawing.Point(58, 193);
            this.lbl_vouchNo.Name = "lbl_vouchNo";
            this.lbl_vouchNo.Size = new System.Drawing.Size(65, 12);
            this.lbl_vouchNo.TabIndex = 16;
            this.lbl_vouchNo.Text = "单据编号：";
            // 
            // horizonLine2
            // 
            this.horizonLine2.LineColor = System.Drawing.SystemColors.ControlText;
            this.horizonLine2.LineWidth = 1;
            this.horizonLine2.Location = new System.Drawing.Point(53, 379);
            this.horizonLine2.Name = "horizonLine2";
            this.horizonLine2.Size = new System.Drawing.Size(800, 1);
            this.horizonLine2.TabIndex = 15;
            // 
            // horizonLine1
            // 
            this.horizonLine1.LineColor = System.Drawing.SystemColors.ControlText;
            this.horizonLine1.LineWidth = 1;
            this.horizonLine1.Location = new System.Drawing.Point(53, 218);
            this.horizonLine1.Name = "horizonLine1";
            this.horizonLine1.Size = new System.Drawing.Size(800, 1);
            this.horizonLine1.TabIndex = 15;
            // 
            // dtp_make
            // 
            this.dtp_make.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_make.Location = new System.Drawing.Point(408, 94);
            this.dtp_make.Name = "dtp_make";
            this.dtp_make.Size = new System.Drawing.Size(124, 21);
            this.dtp_make.TabIndex = 14;
            // 
            // lbl_vouchNoValue
            // 
            this.lbl_vouchNoValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_vouchNoValue.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_vouchNoValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_vouchNoValue.Location = new System.Drawing.Point(121, 193);
            this.lbl_vouchNoValue.Name = "lbl_vouchNoValue";
            this.lbl_vouchNoValue.Size = new System.Drawing.Size(130, 14);
            this.lbl_vouchNoValue.TabIndex = 6;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(345, 98);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(59, 12);
            this.lbl_date.TabIndex = 7;
            this.lbl_date.Text = "制单日期:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(692, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "金额单位:元";
            // 
            // lbl_computeUnit
            // 
            this.lbl_computeUnit.AutoSize = true;
            this.lbl_computeUnit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_computeUnit.Location = new System.Drawing.Point(693, 173);
            this.lbl_computeUnit.Name = "lbl_computeUnit";
            this.lbl_computeUnit.Size = new System.Drawing.Size(71, 12);
            this.lbl_computeUnit.TabIndex = 10;
            this.lbl_computeUnit.Text = "币种:人民币";
            // 
            // lbl_titel
            // 
            this.lbl_titel.AutoSize = true;
            this.lbl_titel.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_titel.Location = new System.Drawing.Point(378, 41);
            this.lbl_titel.Name = "lbl_titel";
            this.lbl_titel.Size = new System.Drawing.Size(135, 29);
            this.lbl_titel.TabIndex = 12;
            this.lbl_titel.Text = "收 款 单";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 455F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_personCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_money, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_customerCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_custName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtp_income, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 240);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 117);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // lbl_personCode
            // 
            this.lbl_personCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_personCode.AutoSize = true;
            this.lbl_personCode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_personCode.Location = new System.Drawing.Point(3, 81);
            this.lbl_personCode.Name = "lbl_personCode";
            this.lbl_personCode.Size = new System.Drawing.Size(59, 12);
            this.lbl_personCode.TabIndex = 1;
            this.lbl_personCode.Text = "收款日期:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(538, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "收款金额:";
            // 
            // txt_money
            // 
            this.txt_money.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_money.Location = new System.Drawing.Point(607, 18);
            this.txt_money.Name = "txt_money";
            this.txt_money.Size = new System.Drawing.Size(190, 21);
            this.txt_money.TabIndex = 0;
            this.txt_money.Tag = "收款金额";
            // 
            // lbl_customerCode
            // 
            this.lbl_customerCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_customerCode.AutoSize = true;
            this.lbl_customerCode.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_customerCode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_customerCode.Location = new System.Drawing.Point(3, 23);
            this.lbl_customerCode.Name = "lbl_customerCode";
            this.lbl_customerCode.Size = new System.Drawing.Size(59, 12);
            this.lbl_customerCode.TabIndex = 1;
            this.lbl_customerCode.Text = "客户单位:";
            // 
            // cmb_custName
            // 
            this.cmb_custName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_custName.FormattingEnabled = true;
            this.cmb_custName.Location = new System.Drawing.Point(83, 19);
            this.cmb_custName.Name = "cmb_custName";
            this.cmb_custName.Size = new System.Drawing.Size(174, 20);
            this.cmb_custName.TabIndex = 2;
            // 
            // dtp_income
            // 
            this.dtp_income.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_income.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_income.Location = new System.Drawing.Point(83, 77);
            this.dtp_income.Name = "dtp_income";
            this.dtp_income.Size = new System.Drawing.Size(174, 21);
            this.dtp_income.TabIndex = 3;
            // 
            // pnl_query
            // 
            this.pnl_query.Controls.Add(this.btn_query);
            this.pnl_query.Controls.Add(this.rtxt_voucherNO);
            this.pnl_query.Location = new System.Drawing.Point(649, 124);
            this.pnl_query.Name = "pnl_query";
            this.pnl_query.Size = new System.Drawing.Size(200, 46);
            this.pnl_query.TabIndex = 19;
            // 
            // btn_query
            // 
            this.btn_query.BackColor = System.Drawing.Color.Transparent;
            this.btn_query.ForeColor = System.Drawing.Color.Black;
            this.btn_query.Image = ((System.Drawing.Image)(resources.GetObject("btn_query.Image")));
            this.btn_query.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_query.Location = new System.Drawing.Point(171, 18);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(21, 22);
            this.btn_query.TabIndex = 17;
            this.btn_query.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_query.UseVisualStyleBackColor = false;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // rtxt_voucherNO
            // 
            this.rtxt_voucherNO.Location = new System.Drawing.Point(47, 15);
            this.rtxt_voucherNO.Name = "rtxt_voucherNO";
            this.rtxt_voucherNO.Size = new System.Drawing.Size(150, 28);
            this.rtxt_voucherNO.TabIndex = 18;
            this.rtxt_voucherNO.Text = "";
            // 
            // ts_income
            // 
            this.ts_income.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_new,
            this.tsb_save,
            this.tsb_query,
            this.tsb_modify,
            this.tsb_print,
            this.tsb_close});
            this.ts_income.Location = new System.Drawing.Point(0, 0);
            this.ts_income.Name = "ts_income";
            this.ts_income.Size = new System.Drawing.Size(1052, 25);
            this.ts_income.TabIndex = 7;
            this.ts_income.Text = "toolStrip1";
            // 
            // tsb_new
            // 
            this.tsb_new.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_new.Image = ((System.Drawing.Image)(resources.GetObject("tsb_new.Image")));
            this.tsb_new.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_new.Name = "tsb_new";
            this.tsb_new.Size = new System.Drawing.Size(23, 22);
            this.tsb_new.Text = "新增";
            this.tsb_new.Click += new System.EventHandler(this.Tsb_new_Click);
            // 
            // tsb_save
            // 
            this.tsb_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_save.Image = ((System.Drawing.Image)(resources.GetObject("tsb_save.Image")));
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Size = new System.Drawing.Size(23, 22);
            this.tsb_save.Text = "保存";
            this.tsb_save.Click += new System.EventHandler(this.tsb_save_Click);
            // 
            // tsb_query
            // 
            this.tsb_query.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_query.Image = ((System.Drawing.Image)(resources.GetObject("tsb_query.Image")));
            this.tsb_query.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_query.Name = "tsb_query";
            this.tsb_query.Size = new System.Drawing.Size(23, 22);
            this.tsb_query.Text = "查询";
            this.tsb_query.Click += new System.EventHandler(this.tsb_query_Click);
            // 
            // tsb_modify
            // 
            this.tsb_modify.Image = ((System.Drawing.Image)(resources.GetObject("tsb_modify.Image")));
            this.tsb_modify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_modify.Name = "tsb_modify";
            this.tsb_modify.Size = new System.Drawing.Size(52, 22);
            this.tsb_modify.Text = "修改";
            this.tsb_modify.Click += new System.EventHandler(this.tsb_modify_Click);
            // 
            // tsb_print
            // 
            this.tsb_print.Image = ((System.Drawing.Image)(resources.GetObject("tsb_print.Image")));
            this.tsb_print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_print.Name = "tsb_print";
            this.tsb_print.Size = new System.Drawing.Size(52, 22);
            this.tsb_print.Text = "打印";
            this.tsb_print.Click += new System.EventHandler(this.Tsb_print_Click);
            // 
            // tsb_close
            // 
            this.tsb_close.Image = ((System.Drawing.Image)(resources.GetObject("tsb_close.Image")));
            this.tsb_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_close.Name = "tsb_close";
            this.tsb_close.Size = new System.Drawing.Size(52, 22);
            this.tsb_close.Text = "关闭";
            this.tsb_close.Click += new System.EventHandler(this.Tsb_close_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Frm_income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 493);
            this.Controls.Add(this.ts_income);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Frm_income";
            this.Text = "收款单";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_income_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnl_query.ResumeLayout(false);
            this.ts_income.ResumeLayout(false);
            this.ts_income.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_make;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_computeUnit;
        private System.Windows.Forms.Label lbl_titel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_customerCode;
        private System.Windows.Forms.Label lbl_personCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_money;
        private System.Windows.Forms.ToolStrip ts_income;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripButton tsb_print;
        private System.Windows.Forms.ToolStripButton tsb_close;
        private Utility.UControl.HorizonLine horizonLine2;
        private Utility.UControl.HorizonLine horizonLine1;
        private System.Windows.Forms.Label lbl_vouchNo;
        private System.Windows.Forms.Label lbl_vouchNoValue;
        private System.Windows.Forms.ToolStripButton tsb_new;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ComboBox cmb_custName;
        private System.Windows.Forms.DateTimePicker dtp_income;
        //实现从报表到表单的穿透查询，故把该变量公开
        public System.Windows.Forms.ToolStripButton tsb_query;
        public System.Windows.Forms.RichTextBox rtxt_voucherNO;
        public System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.Panel pnl_query;
        private System.Windows.Forms.ToolStripButton tsb_modify;
    }
}

