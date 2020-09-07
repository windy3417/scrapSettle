using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace scrapSettlement
{
    public partial class Frm_weighingSettltement : Form
    {
        public Frm_weighingSettltement()
        {
            InitializeComponent();
            this.FormClosed +=new FormClosedEventHandler (this.closeParent);
        }

        private void Tsb_print_Click(object sender, EventArgs e)
        {
           
            this.printPreviewDialog1.Show();
        }

        private void Tsb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeParent(object sender,FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }
    }
}
