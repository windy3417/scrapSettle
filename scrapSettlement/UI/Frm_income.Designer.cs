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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_new = new System.Windows.Forms.ToolStripButton();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_print = new System.Windows.Forms.ToolStripButton();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.cmb_custName = new System.Windows.Forms.ComboBox();
            this.dtp_income = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.panel1.Location = new System.Drawing.Point(81, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 462);
            this.panel1.TabIndex = 6;
            // 
            // lbl_vouchNo
            // 
            this.lbl_vouchNo.AutoSize = true;
            this.lbl_vouchNo.Location = new System.Drawing.Point(162, 141);
            this.lbl_vouchNo.Name = "lbl_vouchNo";
            this.lbl_vouchNo.Size = new System.Drawing.Size(65, 12);
            this.lbl_vouchNo.TabIndex = 16;
            this.lbl_vouchNo.Text = "单据编号：";
            // 
            // horizonLine2
            // 
            this.horizonLine2.LineColor = System.Drawing.SystemColors.ControlText;
            this.horizonLine2.LineWidth = 1;
            this.horizonLine2.Location = new System.Drawing.Point(164, 401);
            this.horizonLine2.Name = "horizonLine2";
            this.horizonLine2.Size = new System.Drawing.Size(578, 1);
            this.horizonLine2.TabIndex = 15;
            // 
            // horizonLine1
            // 
            this.horizonLine1.LineColor = System.Drawing.SystemColors.ControlText;
            this.horizonLine1.LineWidth = 1;
            this.horizonLine1.Location = new System.Drawing.Point(164, 165);
            this.horizonLine1.Name = "horizonLine1";
            this.horizonLine1.Size = new System.Drawing.Size(578, 1);
            this.horizonLine1.TabIndex = 15;
            // 
            // dtp_make
            // 
            this.dtp_make.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_make.Location = new System.Drawing.Point(385, 66);
            this.dtp_make.Name = "dtp_make";
            this.dtp_make.Size = new System.Drawing.Size(124, 21);
            this.dtp_make.TabIndex = 14;
            // 
            // lbl_vouchNoValue
            // 
            this.lbl_vouchNoValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_vouchNoValue.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_vouchNoValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_vouchNoValue.Location = new System.Drawing.Point(229, 141);
            this.lbl_vouchNoValue.Name = "lbl_vouchNoValue";
            this.lbl_vouchNoValue.Size = new System.Drawing.Size(130, 14);
            this.lbl_vouchNoValue.TabIndex = 6;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(322, 70);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(59, 12);
            this.lbl_date.TabIndex = 7;
            this.lbl_date.Text = "制单日期:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(617, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "金额单位:元";
            // 
            // lbl_computeUnit
            // 
            this.lbl_computeUnit.AutoSize = true;
            this.lbl_computeUnit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_computeUnit.Location = new System.Drawing.Point(617, 121);
            this.lbl_computeUnit.Name = "lbl_computeUnit";
            this.lbl_computeUnit.Size = new System.Drawing.Size(71, 12);
            this.lbl_computeUnit.TabIndex = 10;
            this.lbl_computeUnit.Text = "币种:人民币";
            // 
            // lbl_titel
            // 
            this.lbl_titel.AutoSize = true;
            this.lbl_titel.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_titel.Location = new System.Drawing.Point(364, 19);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_personCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_money, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_customerCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_custName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtp_income, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(190, 188);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 117);
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
            this.label1.Location = new System.Drawing.Point(263, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "收款金额:";
            // 
            // txt_money
            // 
            this.txt_money.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_money.Location = new System.Drawing.Point(333, 18);
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_new,
            this.tsb_save,
            this.tsb_print,
            this.tsb_close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1052, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
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
            // Frm_income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 493);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_income";
            this.Text = "过磅结算单";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
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
    }
}

