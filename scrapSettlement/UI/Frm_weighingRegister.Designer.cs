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
            this.pnl_query = new System.Windows.Forms.Panel();
            this.btn_query = new System.Windows.Forms.Button();
            this.rtxt_voucherNO = new System.Windows.Forms.RichTextBox();
            this.lbl_vouchNo = new System.Windows.Forms.Label();
            this.horizonLine2 = new Utility.UControl.HorizonLine();
            this.horizonLine1 = new Utility.UControl.HorizonLine();
            this.dtp_makeDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_vouchNoValue = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_computeUnit = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_titel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_customerCode = new System.Windows.Forms.Label();
            this.cmb_custName = new System.Windows.Forms.ComboBox();
            this.cmb_person = new System.Windows.Forms.ComboBox();
            this.lbl_personCode = new System.Windows.Forms.Label();
            this.lbl_scrapCode = new System.Windows.Forms.Label();
            this.cmb_scrapName = new System.Windows.Forms.ComboBox();
            this.txt_grossWeight = new System.Windows.Forms.TextBox();
            this.lbl_grossWeght = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_money = new System.Windows.Forms.TextBox();
            this.lbl_tare = new System.Windows.Forms.Label();
            this.lbl_netWeight = new System.Windows.Forms.Label();
            this.txt_tare = new System.Windows.Forms.TextBox();
            this.txt_netWeight = new System.Windows.Forms.TextBox();
            this.lbl_vechiclBrand = new System.Windows.Forms.Label();
            this.cmb_vehicleBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_coefficient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_webUnitPrice = new System.Windows.Forms.TextBox();
            this.lbl_settleUnitPrice = new System.Windows.Forms.Label();
            this.txt_settleUnitPrice = new System.Windows.Forms.TextBox();
            this.lbl_weighingTime = new System.Windows.Forms.Label();
            this.txt_weighingTime = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_new = new System.Windows.Forms.ToolStripButton();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_abandon = new System.Windows.Forms.ToolStripButton();
            this.tsb_modify = new System.Windows.Forms.ToolStripButton();
            this.tsb_query = new System.Windows.Forms.ToolStripButton();
            this.tsb_previewPrint = new System.Windows.Forms.ToolStripButton();
            this.tsb_print = new System.Windows.Forms.ToolStripButton();
            this.tsb_delete = new System.Windows.Forms.ToolStripButton();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.tsb_audit = new System.Windows.Forms.ToolStripButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lbl_voucherState = new System.Windows.Forms.Label();
            this.lbl_voucherStateValue = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_query.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.pnl_query);
            this.panel1.Controls.Add(this.lbl_voucherState);
            this.panel1.Controls.Add(this.lbl_vouchNo);
            this.panel1.Controls.Add(this.horizonLine2);
            this.panel1.Controls.Add(this.horizonLine1);
            this.panel1.Controls.Add(this.dtp_makeDate);
            this.panel1.Controls.Add(this.lbl_voucherStateValue);
            this.panel1.Controls.Add(this.lbl_vouchNoValue);
            this.panel1.Controls.Add(this.lbl_balance);
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_computeUnit);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.lbl_titel);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(79, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 574);
            this.panel1.TabIndex = 6;
            // 
            // pnl_query
            // 
            this.pnl_query.Controls.Add(this.btn_query);
            this.pnl_query.Controls.Add(this.rtxt_voucherNO);
            this.pnl_query.Location = new System.Drawing.Point(573, 51);
            this.pnl_query.Name = "pnl_query";
            this.pnl_query.Size = new System.Drawing.Size(200, 46);
            this.pnl_query.TabIndex = 20;
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
            this.horizonLine2.Location = new System.Drawing.Point(164, 496);
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
            // dtp_makeDate
            // 
            this.dtp_makeDate.Location = new System.Drawing.Point(385, 66);
            this.dtp_makeDate.Name = "dtp_makeDate";
            this.dtp_makeDate.Size = new System.Drawing.Size(124, 21);
            this.dtp_makeDate.TabIndex = 14;
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
            // lbl_balance
            // 
            this.lbl_balance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_balance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_balance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_balance.Location = new System.Drawing.Point(555, 506);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_balance.Size = new System.Drawing.Size(162, 24);
            this.lbl_balance.TabIndex = 6;
            this.lbl_balance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.lbl.Location = new System.Drawing.Point(459, 510);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_customerCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_custName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_person, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_personCode, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_scrapCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmb_scrapName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_grossWeight, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_grossWeght, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_money, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_tare, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_netWeight, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_tare, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_netWeight, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_vechiclBrand, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmb_vehicleBrand, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_coefficient, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_webUnitPrice, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_settleUnitPrice, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_settleUnitPrice, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_weighingTime, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_weighingTime, 3, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(190, 188);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 234);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // lbl_customerCode
            // 
            this.lbl_customerCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_customerCode.AutoSize = true;
            this.lbl_customerCode.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_customerCode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_customerCode.Location = new System.Drawing.Point(3, 13);
            this.lbl_customerCode.Name = "lbl_customerCode";
            this.lbl_customerCode.Size = new System.Drawing.Size(59, 12);
            this.lbl_customerCode.TabIndex = 1;
            this.lbl_customerCode.Text = "客户单位:";
            // 
            // cmb_custName
            // 
            this.cmb_custName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_custName.FormattingEnabled = true;
            this.cmb_custName.Location = new System.Drawing.Point(83, 9);
            this.cmb_custName.Name = "cmb_custName";
            this.cmb_custName.Size = new System.Drawing.Size(154, 20);
            this.cmb_custName.TabIndex = 1;
            this.cmb_custName.SelectedValueChanged += new System.EventHandler(this.cmb_custName_SelectedValueChanged);
            // 
            // cmb_person
            // 
            this.cmb_person.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_person.FormattingEnabled = true;
            this.cmb_person.Location = new System.Drawing.Point(341, 9);
            this.cmb_person.Name = "cmb_person";
            this.cmb_person.Size = new System.Drawing.Size(157, 20);
            this.cmb_person.TabIndex = 7;
            // 
            // lbl_personCode
            // 
            this.lbl_personCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_personCode.AutoSize = true;
            this.lbl_personCode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_personCode.Location = new System.Drawing.Point(252, 13);
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
            this.lbl_scrapCode.Location = new System.Drawing.Point(3, 51);
            this.lbl_scrapCode.Name = "lbl_scrapCode";
            this.lbl_scrapCode.Size = new System.Drawing.Size(59, 12);
            this.lbl_scrapCode.TabIndex = 1;
            this.lbl_scrapCode.Text = "废料名称:";
            // 
            // cmb_scrapName
            // 
            this.cmb_scrapName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_scrapName.FormattingEnabled = true;
            this.cmb_scrapName.Location = new System.Drawing.Point(83, 47);
            this.cmb_scrapName.Name = "cmb_scrapName";
            this.cmb_scrapName.Size = new System.Drawing.Size(154, 20);
            this.cmb_scrapName.TabIndex = 2;
            this.cmb_scrapName.SelectedValueChanged += new System.EventHandler(this.cmb_scrapName_SelectedValueChanged);
            // 
            // txt_grossWeight
            // 
            this.txt_grossWeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_grossWeight.Location = new System.Drawing.Point(83, 122);
            this.txt_grossWeight.Name = "txt_grossWeight";
            this.txt_grossWeight.Size = new System.Drawing.Size(154, 21);
            this.txt_grossWeight.TabIndex = 4;
            this.txt_grossWeight.Leave += new System.EventHandler(this.txt_grossWeight_Leave);
            // 
            // lbl_grossWeght
            // 
            this.lbl_grossWeght.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_grossWeght.AutoSize = true;
            this.lbl_grossWeght.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_grossWeght.Location = new System.Drawing.Point(3, 127);
            this.lbl_grossWeght.Name = "lbl_grossWeght";
            this.lbl_grossWeght.Size = new System.Drawing.Size(59, 12);
            this.lbl_grossWeght.TabIndex = 1;
            this.lbl_grossWeght.Text = "毛重(KG):";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(252, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "结算金额:";
            // 
            // txt_money
            // 
            this.txt_money.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_money.Location = new System.Drawing.Point(341, 160);
            this.txt_money.Name = "txt_money";
            this.txt_money.Size = new System.Drawing.Size(157, 21);
            this.txt_money.TabIndex = 0;
            this.txt_money.TextChanged += new System.EventHandler(this.txt_money_TextChanged);
            // 
            // lbl_tare
            // 
            this.lbl_tare.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_tare.AutoSize = true;
            this.lbl_tare.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_tare.Location = new System.Drawing.Point(3, 165);
            this.lbl_tare.Name = "lbl_tare";
            this.lbl_tare.Size = new System.Drawing.Size(59, 12);
            this.lbl_tare.TabIndex = 9;
            this.lbl_tare.Text = "皮重(KG):";
            // 
            // lbl_netWeight
            // 
            this.lbl_netWeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_netWeight.AutoSize = true;
            this.lbl_netWeight.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_netWeight.Location = new System.Drawing.Point(3, 206);
            this.lbl_netWeight.Name = "lbl_netWeight";
            this.lbl_netWeight.Size = new System.Drawing.Size(59, 12);
            this.lbl_netWeight.TabIndex = 7;
            this.lbl_netWeight.Text = "净重(KG):";
            // 
            // txt_tare
            // 
            this.txt_tare.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_tare.Location = new System.Drawing.Point(83, 160);
            this.txt_tare.Name = "txt_tare";
            this.txt_tare.Size = new System.Drawing.Size(154, 21);
            this.txt_tare.TabIndex = 5;
            this.txt_tare.Leave += new System.EventHandler(this.txt_tare_Leave);
            // 
            // txt_netWeight
            // 
            this.txt_netWeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_netWeight.Enabled = false;
            this.txt_netWeight.Location = new System.Drawing.Point(83, 201);
            this.txt_netWeight.Name = "txt_netWeight";
            this.txt_netWeight.Size = new System.Drawing.Size(154, 21);
            this.txt_netWeight.TabIndex = 6;
            this.txt_netWeight.Leave += new System.EventHandler(this.txt_netWeight_Leave);
            // 
            // lbl_vechiclBrand
            // 
            this.lbl_vechiclBrand.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_vechiclBrand.AutoSize = true;
            this.lbl_vechiclBrand.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_vechiclBrand.Location = new System.Drawing.Point(3, 89);
            this.lbl_vechiclBrand.Name = "lbl_vechiclBrand";
            this.lbl_vechiclBrand.Size = new System.Drawing.Size(35, 12);
            this.lbl_vechiclBrand.TabIndex = 1;
            this.lbl_vechiclBrand.Text = "车牌:";
            // 
            // cmb_vehicleBrand
            // 
            this.cmb_vehicleBrand.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_vehicleBrand.FormattingEnabled = true;
            this.cmb_vehicleBrand.Location = new System.Drawing.Point(83, 85);
            this.cmb_vehicleBrand.Name = "cmb_vehicleBrand";
            this.cmb_vehicleBrand.Size = new System.Drawing.Size(154, 20);
            this.cmb_vehicleBrand.TabIndex = 3;
            this.cmb_vehicleBrand.SelectedValueChanged += new System.EventHandler(this.cmb_scrapName_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(252, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "结算系数:";
            // 
            // txt_coefficient
            // 
            this.txt_coefficient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_coefficient.Enabled = false;
            this.txt_coefficient.Location = new System.Drawing.Point(341, 46);
            this.txt_coefficient.Name = "txt_coefficient";
            this.txt_coefficient.Size = new System.Drawing.Size(154, 21);
            this.txt_coefficient.TabIndex = 0;
            this.txt_coefficient.TextChanged += new System.EventHandler(this.txt_coefficient_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(252, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "网价(RMB/吨):";
            // 
            // txt_webUnitPrice
            // 
            this.txt_webUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_webUnitPrice.Location = new System.Drawing.Point(341, 84);
            this.txt_webUnitPrice.Name = "txt_webUnitPrice";
            this.txt_webUnitPrice.Size = new System.Drawing.Size(157, 21);
            this.txt_webUnitPrice.TabIndex = 8;
            this.txt_webUnitPrice.Leave += new System.EventHandler(this.txt_webUnitPrice_Leave);
            // 
            // lbl_settleUnitPrice
            // 
            this.lbl_settleUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_settleUnitPrice.AutoSize = true;
            this.lbl_settleUnitPrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_settleUnitPrice.Location = new System.Drawing.Point(252, 127);
            this.lbl_settleUnitPrice.Name = "lbl_settleUnitPrice";
            this.lbl_settleUnitPrice.Size = new System.Drawing.Size(59, 12);
            this.lbl_settleUnitPrice.TabIndex = 1;
            this.lbl_settleUnitPrice.Text = "结算单价:";
            // 
            // txt_settleUnitPrice
            // 
            this.txt_settleUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_settleUnitPrice.Location = new System.Drawing.Point(341, 122);
            this.txt_settleUnitPrice.Name = "txt_settleUnitPrice";
            this.txt_settleUnitPrice.Size = new System.Drawing.Size(157, 21);
            this.txt_settleUnitPrice.TabIndex = 6;
            // 
            // lbl_weighingTime
            // 
            this.lbl_weighingTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_weighingTime.AutoSize = true;
            this.lbl_weighingTime.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_weighingTime.Location = new System.Drawing.Point(252, 206);
            this.lbl_weighingTime.Name = "lbl_weighingTime";
            this.lbl_weighingTime.Size = new System.Drawing.Size(59, 12);
            this.lbl_weighingTime.TabIndex = 1;
            this.lbl_weighingTime.Text = "过磅时间:";
            // 
            // txt_weighingTime
            // 
            this.txt_weighingTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_weighingTime.Location = new System.Drawing.Point(341, 201);
            this.txt_weighingTime.Name = "txt_weighingTime";
            this.txt_weighingTime.Size = new System.Drawing.Size(157, 21);
            this.txt_weighingTime.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_new,
            this.tsb_save,
            this.tsb_audit,
            this.tsb_abandon,
            this.tsb_modify,
            this.tsb_query,
            this.tsb_previewPrint,
            this.tsb_print,
            this.tsb_delete,
            this.tsb_close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1056, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_new
            // 
            this.tsb_new.Image = ((System.Drawing.Image)(resources.GetObject("tsb_new.Image")));
            this.tsb_new.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_new.Name = "tsb_new";
            this.tsb_new.Size = new System.Drawing.Size(52, 22);
            this.tsb_new.Text = "新增";
            this.tsb_new.Click += new System.EventHandler(this.Tsb_new_Click);
            // 
            // tsb_save
            // 
            this.tsb_save.Image = ((System.Drawing.Image)(resources.GetObject("tsb_save.Image")));
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Size = new System.Drawing.Size(52, 22);
            this.tsb_save.Text = "保存";
            this.tsb_save.Click += new System.EventHandler(this.tsb_save_Click);
            // 
            // tsb_abandon
            // 
            this.tsb_abandon.Image = ((System.Drawing.Image)(resources.GetObject("tsb_abandon.Image")));
            this.tsb_abandon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_abandon.Name = "tsb_abandon";
            this.tsb_abandon.Size = new System.Drawing.Size(52, 22);
            this.tsb_abandon.Text = "放弃";
            this.tsb_abandon.Click += new System.EventHandler(this.tsb_abandon_Click);
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
            // tsb_query
            // 
            this.tsb_query.Image = ((System.Drawing.Image)(resources.GetObject("tsb_query.Image")));
            this.tsb_query.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_query.Name = "tsb_query";
            this.tsb_query.Size = new System.Drawing.Size(52, 22);
            this.tsb_query.Text = "查询";
            this.tsb_query.Click += new System.EventHandler(this.tsb_query_Click);
            // 
            // tsb_previewPrint
            // 
            this.tsb_previewPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsb_previewPrint.Image")));
            this.tsb_previewPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_previewPrint.Name = "tsb_previewPrint";
            this.tsb_previewPrint.Size = new System.Drawing.Size(52, 22);
            this.tsb_previewPrint.Text = "预览";
            this.tsb_previewPrint.Click += new System.EventHandler(this.tsb_previewPrint_Click);
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
            // tsb_delete
            // 
            this.tsb_delete.Image = ((System.Drawing.Image)(resources.GetObject("tsb_delete.Image")));
            this.tsb_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_delete.Name = "tsb_delete";
            this.tsb_delete.Size = new System.Drawing.Size(52, 22);
            this.tsb_delete.Text = "删除";
            this.tsb_delete.Click += new System.EventHandler(this.tsb_delete_Click);
            // 
            // tsb_close
            // 
            this.tsb_close.Image = global::scrapSettlement.Properties.Resources.exit;
            this.tsb_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_close.Name = "tsb_close";
            this.tsb_close.Size = new System.Drawing.Size(52, 22);
            this.tsb_close.Text = "关闭";
            this.tsb_close.Click += new System.EventHandler(this.Tsb_close_Click);
            // 
            // tsb_audit
            // 
            this.tsb_audit.Image = global::scrapSettlement.Properties.Resources.Authorization;
            this.tsb_audit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_audit.Name = "tsb_audit";
            this.tsb_audit.Size = new System.Drawing.Size(52, 22);
            this.tsb_audit.Text = "审核";
            this.tsb_audit.Click += new System.EventHandler(this.tsb_audit_Click);
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // lbl_voucherState
            // 
            this.lbl_voucherState.AutoSize = true;
            this.lbl_voucherState.Location = new System.Drawing.Point(600, 19);
            this.lbl_voucherState.Name = "lbl_voucherState";
            this.lbl_voucherState.Size = new System.Drawing.Size(65, 12);
            this.lbl_voucherState.TabIndex = 16;
            this.lbl_voucherState.Text = "单据状态：";
            // 
            // lbl_voucherStateValue
            // 
            this.lbl_voucherStateValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_voucherStateValue.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_voucherStateValue.ForeColor = System.Drawing.Color.Red;
            this.lbl_voucherStateValue.Location = new System.Drawing.Point(671, 17);
            this.lbl_voucherStateValue.Name = "lbl_voucherStateValue";
            this.lbl_voucherStateValue.Size = new System.Drawing.Size(71, 14);
            this.lbl_voucherStateValue.TabIndex = 6;
            // 
            // Frm_weighingSettltement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 625);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Frm_weighingSettltement";
            this.Text = "过磅结算单";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_weighingSettltement_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_weighingSettltement_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_query.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_makeDate;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_computeUnit;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl_titel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_customerCode;
        private System.Windows.Forms.Label lbl_personCode;
        private System.Windows.Forms.Label lbl_scrapCode;
        private System.Windows.Forms.Label lbl_grossWeght;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_settleUnitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_webUnitPrice;
        private System.Windows.Forms.TextBox txt_settleUnitPrice;
        private System.Windows.Forms.TextBox txt_money;
        private System.Windows.Forms.TextBox txt_grossWeight;
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
        private System.Windows.Forms.ComboBox cmb_scrapName;
        private System.Windows.Forms.ComboBox cmb_person;
        private System.Windows.Forms.TextBox txt_coefficient;
        private System.Windows.Forms.ToolStripButton tsb_previewPrint;
        private System.Windows.Forms.Panel pnl_query;
        //穿透查询功能开放访问
        public System.Windows.Forms.Button btn_query;
        public System.Windows.Forms.RichTextBox rtxt_voucherNO;
        public System.Windows.Forms.ToolStripButton tsb_query;


        private System.Windows.Forms.Label lbl_netWeight;
        private System.Windows.Forms.TextBox txt_netWeight;
        private System.Windows.Forms.Label lbl_tare;
        private System.Windows.Forms.TextBox txt_tare;
        private System.Windows.Forms.Label lbl_vechiclBrand;
        private System.Windows.Forms.ComboBox cmb_vehicleBrand;
        private System.Windows.Forms.Label lbl_weighingTime;
        private System.Windows.Forms.TextBox txt_weighingTime;
        private System.Windows.Forms.ToolStripButton tsb_modify;
        private System.Windows.Forms.ToolStripButton tsb_abandon;
        private System.Windows.Forms.ToolStripButton tsb_delete;
        private System.Windows.Forms.ToolStripButton tsb_audit;
        private System.Windows.Forms.Label lbl_voucherState;
        private System.Windows.Forms.Label lbl_voucherStateValue;
    }
}

