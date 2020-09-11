using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ScrapSettlement.UI
{
    public partial class Frm_scrap
        : Form
    {
        public Frm_scrap()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(this.closeParent);
        }

    

        private void txt_scrapCode_Validating(object sender, CancelEventArgs e)
        {
             string pattern = "^-?[1-9]\\d*$";
            Regex regex = new Regex(pattern);
            if (!regex.Match(txt_scrapCode.Text).Success)
            {

                if (this.txt_scrapCode.Text.Length==0)
                {
                    return;
                }

                else
                {
                    MessageBox.Show("请输入数字作为编码", "输入验证", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_scrapCode.Text = "";
                    this.txt_scrapCode.Focus();
                }
                

            } ;
    }

        private void Tsb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeParent(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }
    }
}
