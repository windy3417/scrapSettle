namespace ScrapSettlement
{
    partial class Frm_weighingSettltement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_weighingSettltement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_computeUnit = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_titel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_personCode = new System.Windows.Forms.Label();
            this.lbl_scrapCode = new System.Windows.Forms.Label();
            this.lbl_settleCoefficient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_settleUnitPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txb_settleUnitPrice = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_customerCode = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_print = new System.Windows.Forms.ToolStripButton();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lbl_vouchNo = new System.Windows.Forms.Label();
            this.lbl_vouchNoValue = new System.Windows.Forms.Label();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_new = new System.Windows.Forms.ToolStripButton();
            this.horizonLine2 = new Utility.UControl.HorizonLine();
            this.horizonLine1 = new Utility.UControl.HorizonLine();
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
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lbl_vouchNoValue);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_computeUnit);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.lbl_titel);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(81, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 462);
            this.panel1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(385, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 21);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(403, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 14);
            this.label5.TabIndex = 6;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(322, 70);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(59, 12);
            this.lbl_date.TabIndex = 7;
            this.lbl_date.Text = "过磅日期:";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(617, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "计量单位:KG";
            // 
            // lbl_computeUnit
            // 
            this.lbl_computeUnit.AutoSize = true;
            this.lbl_computeUnit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_computeUnit.Location = new System.Drawing.Point(617, 121);
            this.lbl_computeUnit.Name = "lbl_computeUnit";
            this.lbl_computeUnit.Size = new System.Drawing.Size(125, 12);
            this.lbl_computeUnit.TabIndex = 10;
            this.lbl_computeUnit.Text = "计价单位:人民币元/吨";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl.Location = new System.Drawing.Point(307, 415);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(90, 14);
            this.lbl.TabIndex = 11;
            this.lbl.Text = "预付款结余:";
            // 
            // lbl_titel
            // 
            this.lbl_titel.AutoSize = true;
            this.lbl_titel.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_titel.Location = new System.Drawing.Point(304, 19);
            this.lbl_titel.Name = "lbl_titel";
            this.lbl_titel.Size = new System.Drawing.Size(227, 29);
            this.lbl_titel.TabIndex = 12;
            this.lbl_titel.Text = "过 磅 结 算 单";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_personCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_scrapCode, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_settleCoefficient, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_settleUnitPrice, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txb_settleUnitPrice, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_customerCode, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(190, 188);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 193);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox2.Location = new System.Drawing.Point(83, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 21);
            this.textBox2.TabIndex = 0;
            // 
            // lbl_personCode
            // 
            this.lbl_personCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_personCode.AutoSize = true;
            this.lbl_personCode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_personCode.Location = new System.Drawing.Point(3, 66);
            this.lbl_personCode.Name = "lbl_personCode";
            this.lbl_personCode.Size = new System.Drawing.Size(71, 12);
            this.lbl_personCode.TabIndex = 1;
            this.lbl_personCode.Text = "经办人姓名:";
            // 
            // lbl_scrapCode
            // 
            this.lbl_scrapCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_scrapCode.AutoSize = true;
            this.lbl_scrapCode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_scrapCode.Location = new System.Drawing.Point(3, 114);
            this.lbl_scrapCode.Name = "lbl_scrapCode";
            this.lbl_scrapCode.Size = new System.Drawing.Size(59, 12);
            this.lbl_scrapCode.TabIndex = 1;
            this.lbl_scrapCode.Text = "废料名称:";
            // 
            // lbl_settleCoefficient
            // 
            this.lbl_settleCoefficient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_settleCoefficient.AutoSize = true;
            this.lbl_settleCoefficient.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_settleCoefficient.Location = new System.Drawing.Point(3, 162);
            this.lbl_settleCoefficient.Name = "lbl_settleCoefficient";
            this.lbl_settleCoefficient.Size = new System.Drawing.Size(59, 12);
            this.lbl_settleCoefficient.TabIndex = 1;
            this.lbl_settleCoefficient.Text = "净重(KG):";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(243, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "结算系数:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(243, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "网价(RMB/吨):";
            // 
            // lbl_settleUnitPrice
            // 
            this.lbl_settleUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_settleUnitPrice.AutoSize = true;
            this.lbl_settleUnitPrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_settleUnitPrice.Location = new System.Drawing.Point(243, 114);
            this.lbl_settleUnitPrice.Name = "lbl_settleUnitPrice";
            this.lbl_settleUnitPrice.Size = new System.Drawing.Size(59, 12);
            this.lbl_settleUnitPrice.TabIndex = 1;
            this.lbl_settleUnitPrice.Text = "结算单价:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(243, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "结算金额:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox3.Location = new System.Drawing.Point(333, 13);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 21);
            this.textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox4.Location = new System.Drawing.Point(333, 61);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(139, 21);
            this.textBox4.TabIndex = 0;
            // 
            // txb_settleUnitPrice
            // 
            this.txb_settleUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txb_settleUnitPrice.Location = new System.Drawing.Point(333, 109);
            this.txb_settleUnitPrice.Name = "txb_settleUnitPrice";
            this.txb_settleUnitPrice.Size = new System.Drawing.Size(139, 21);
            this.txb_settleUnitPrice.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox6.Location = new System.Drawing.Point(333, 158);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(139, 21);
            this.textBox6.TabIndex = 0;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox7.Location = new System.Drawing.Point(83, 158);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(139, 21);
            this.textBox7.TabIndex = 0;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox8.Location = new System.Drawing.Point(83, 109);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(139, 21);
            this.textBox8.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(83, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 21);
            this.textBox1.TabIndex = 0;
            // 
            // lbl_customerCode
            // 
            this.lbl_customerCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_customerCode.AutoSize = true;
            this.lbl_customerCode.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_customerCode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_customerCode.Location = new System.Drawing.Point(3, 18);
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
            // lbl_vouchNo
            // 
            this.lbl_vouchNo.AutoSize = true;
            this.lbl_vouchNo.Location = new System.Drawing.Point(162, 141);
            this.lbl_vouchNo.Name = "lbl_vouchNo";
            this.lbl_vouchNo.Size = new System.Drawing.Size(65, 12);
            this.lbl_vouchNo.TabIndex = 16;
            this.lbl_vouchNo.Text = "单据编号：";
            // 
            // lbl_vouchNoValue
            // 
            this.lbl_vouchNoValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_vouchNoValue.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_vouchNoValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_vouchNoValue.Location = new System.Drawing.Point(224, 139);
            this.lbl_vouchNoValue.Name = "lbl_vouchNoValue";
            this.lbl_vouchNoValue.Size = new System.Drawing.Size(130, 14);
            this.lbl_vouchNoValue.TabIndex = 6;
            // 
            // tsb_save
            // 
            this.tsb_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_save.Image = ((System.Drawing.Image)(resources.GetObject("tsb_save.Image")));
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Size = new System.Drawing.Size(23, 22);
            this.tsb_save.Text = "保存";
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
            // Frm_weighingSettltement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 493);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_weighingSettltement";
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_computeUnit;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl_titel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_customerCode;
        private System.Windows.Forms.Label lbl_personCode;
        private System.Windows.Forms.Label lbl_scrapCode;
        private System.Windows.Forms.Label lbl_settleCoefficient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_settleUnitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txb_settleUnitPrice;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}

