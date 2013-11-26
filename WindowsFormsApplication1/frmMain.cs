using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    
    public partial class frmMain : Form
    {
        string config_file = "C:\\sc_upload\\data";
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.load_config();

            
        }

        private void load_config()
        {
            /**\fn load_config
             * 
             * loads the configuration file, parsing out the required
             * information
             * 
             * @param None
             * 
             * @returns None
             */          
            
        }

        private void do_data_input(object sender, DragEventArgs e)
        {
            MessageBox.Show("BAM");
        }
    }
}
