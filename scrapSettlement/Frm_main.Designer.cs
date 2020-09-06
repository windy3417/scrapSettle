namespace scrapSettlement
{
    partial class Frm_main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基础设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户档案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.废料档案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收入登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.过磅登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础设置ToolStripMenuItem,
            this.收入登记ToolStripMenuItem,
            this.过磅登记ToolStripMenuItem,
            this.报表ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基础设置ToolStripMenuItem
            // 
            this.基础设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客户档案ToolStripMenuItem,
            this.废料档案ToolStripMenuItem});
            this.基础设置ToolStripMenuItem.Name = "基础设置ToolStripMenuItem";
            this.基础设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.基础设置ToolStripMenuItem.Text = "基础设置";
            // 
            // 客户档案ToolStripMenuItem
            // 
            this.客户档案ToolStripMenuItem.Name = "客户档案ToolStripMenuItem";
            this.客户档案ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.客户档案ToolStripMenuItem.Text = "客户档案";
            // 
            // 废料档案ToolStripMenuItem
            // 
            this.废料档案ToolStripMenuItem.Name = "废料档案ToolStripMenuItem";
            this.废料档案ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.废料档案ToolStripMenuItem.Text = "废料档案";
            // 
            // 收入登记ToolStripMenuItem
            // 
            this.收入登记ToolStripMenuItem.Name = "收入登记ToolStripMenuItem";
            this.收入登记ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.收入登记ToolStripMenuItem.Text = "收入登记";
            // 
            // 过磅登记ToolStripMenuItem
            // 
            this.过磅登记ToolStripMenuItem.Name = "过磅登记ToolStripMenuItem";
            this.过磅登记ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.过磅登记ToolStripMenuItem.Text = "过磅登记";
            this.过磅登记ToolStripMenuItem.Click += new System.EventHandler(this.过磅登记ToolStripMenuItem_Click);
            // 
            // 报表ToolStripMenuItem
            // 
            this.报表ToolStripMenuItem.Name = "报表ToolStripMenuItem";
            this.报表ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.报表ToolStripMenuItem.Text = "报表";
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_main";
            this.Text = "过磅结算系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基础设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户档案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 废料档案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收入登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 过磅登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报表ToolStripMenuItem;
    }
}