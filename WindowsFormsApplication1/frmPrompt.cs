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
    public partial class frmPrompt : Form
    {

        string selected_input;
        
        Dictionary<String, String> param_map = new Dictionary<String, String>();

        public Dictionary<String, String> input_data = new Dictionary<String, String>();
      
        public frmPrompt()
        {
            InitializeComponent();

            this.param_map.Add("title", "Track Title: ");
            this.param_map.Add("genre", "Genre: ");
            this.param_map.Add("sc_tags", "Soundcloud Tags (Comma separated): ");
            this.param_map.Add("mtags", "Meta Tags: ");
            this.param_map.Add("dls", "Make this track Downloadable? (Yes or No): ");
            this.param_map.Add("private", "Make this track Private? (Yes or No): ");

            this.input_data.Add("title", "");
            this.input_data.Add("genre", "");
            this.input_data.Add("sc_tags", "");
            this.input_data.Add("mtags", "");
            this.input_data.Add("dls", "");
            this.input_data.Add("private", "");
        }

        private void btnNext_Click(object sender, EventArgs e){
            this.input_data[this.selected_input] = this.txtInput.Text;

            Dictionary<string,String>.KeyCollection keys = this.param_map.Keys;


            
        }
    }
}
