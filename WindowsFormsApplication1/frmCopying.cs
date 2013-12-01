using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soundcloud_uploader_client
{
    public partial class frmCopying : Form
    {
        public frmCopying()
        {
            InitializeComponent();
        }

        public void _show()
        {
            tmrContinuing.Enabled = true;
            this.lblCopying.Text = "Copying";
            this.Show();
        }

        public void _hide()
        {
            tmrContinuing.Enabled = false;
            this.lblCopying.Text = "Copying";
            this.Hide();
        }

        private void tmrContinuing_Tick(object sender, EventArgs e)
        {           
            this.lblCopying.Text = this.lblCopying.Text + ".";
        }

        private void frmCopying_Load(object sender, EventArgs e)
        {

        }
    }
}
