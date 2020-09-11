namespace ScrapSettlement.UI
{
    partial class Frm_scrap

    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_scrap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_scrapName = new System.Windows.Forms.Label();
            this.lbl_scrapCode = new System.Windows.Forms.Label();
            this.txt_scrapCode = new System.Windows.Forms.TextBox();
            this.tex_cusName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.lbl_customer);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(27, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 386);
            this.panel1.TabIndex = 0;
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_customer.Location = new System.Drawing.Point(337, 45);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(134, 21);
            this.lbl_customer.TabIndex = 1;
            this.lbl_customer.Text = "废 料 档 案";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_scrapName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_scrapCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_scrapCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tex_cusName, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(175, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_scrapName
            // 
            this.lbl_scrapName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_scrapName.AutoSize = true;
            this.lbl_scrapName.Location = new System.Drawing.Point(3, 69);
            this.lbl_scrapName.Name = "lbl_scrapName";
            this.lbl_scrapName.Size = new System.Drawing.Size(59, 12);
            this.lbl_scrapName.TabIndex = 0;
            this.lbl_scrapName.Text = "废料名称:";
            // 
            // lbl_scrapCode
            // 
            this.lbl_scrapCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_scrapCode.AutoSize = true;
            this.lbl_scrapCode.Location = new System.Drawing.Point(3, 19);
            this.lbl_scrapCode.Name = "lbl_scrapCode";
            this.lbl_scrapCode.Size = new System.Drawing.Size(65, 12);
            this.lbl_scrapCode.TabIndex = 0;
            this.lbl_scrapCode.Text = "废料编码：";
            // 
            // txt_scrapCode
            // 
            this.txt_scrapCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_scrapCode.Location = new System.Drawing.Point(105, 14);
            this.txt_scrapCode.Name = "txt_scrapCode";
            this.txt_scrapCode.Size = new System.Drawing.Size(252, 21);
            this.txt_scrapCode.TabIndex = 1;
            this.txt_scrapCode.Validating += new System.ComponentModel.CancelEventHandler(this.txt_scrapCode_Validating);
            // 
            // tex_cusName
            // 
            this.tex_cusName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tex_cusName.Location = new System.Drawing.Point(105, 64);
            this.tex_cusName.Name = "tex_cusName";
            this.tex_cusName.Size = new System.Drawing.Size(252, 21);
            this.tex_cusName.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_save,
            this.tsb_close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            // tsb_close
            // 
            this.tsb_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_close.Image = ((System.Drawing.Image)(resources.GetObject("tsb_close.Image")));
            this.tsb_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_close.Name = "tsb_close";
            this.tsb_close.Size = new System.Drawing.Size(23, 22);
            this.tsb_close.Text = "关闭";
            this.tsb_close.Click += new System.EventHandler(this.Tsb_close_Click);
            // 
            // Frm_scrap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_scrap";
            this.Text = "废料档案";
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
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_scrapName;
        private System.Windows.Forms.Label lbl_scrapCode;
        private System.Windows.Forms.TextBox txt_scrapCode;
        private System.Windows.Forms.TextBox tex_cusName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripButton tsb_close;
    }
}