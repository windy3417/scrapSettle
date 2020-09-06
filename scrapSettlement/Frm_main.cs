using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace scrapSettlement
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
        }

        private void 过磅登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_weighingSettltement w = new Frm_weighingSettltement();
            w.Show();
        }
    }
}
