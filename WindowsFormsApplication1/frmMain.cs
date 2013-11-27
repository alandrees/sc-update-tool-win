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

        Dictionary<String, String> param_map = new Dictionary<String, String>();


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

        private void do_data_input(object sender, DragEventArgs e){
            object data = e.Data.GetData(e.Data.GetType());

            Form prompt = new frmPrompt();
            prompt.ShowDialog();

            Dictionary<String, String> input_data = prompt.input_data;


        }

        private void frmMain_DragEnter(object sender, DragEventArgs e){
            if( e.Data.GetDataPresent(DataFormats.FileDrop) ){
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
