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
    public partial class frmPrompt : Form
    {

        int selected_key;
        string[] keylist;
        
        Dictionary<String, String> param_map = new Dictionary<String, String>();

        public Dictionary<String, String> input_data = new Dictionary<String, String>();
      
        public frmPrompt(string filename)
        {
            InitializeComponent();

            this.param_map.Add("title", "Track Title (required): ");
            this.param_map.Add("genre", "Genre (required): ");
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

            this.selected_key = 0;
            this.keylist = param_map.Keys.ToArray();
            this.Text = filename;
        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.selected_key < (this.param_map.Count() - 2))
            {
                this.input_data[this.keylist[this.selected_key]] = txtInput.Text;   
                this.selected_key++;
                this.populate_form_data();
                txtInput.Text = "";
                this.txtInput.Focus();

            }
            else if (((this.param_map.Count() - 1) - this.selected_key) == 1)
            {
                this.input_data[this.keylist[this.selected_key]] = txtInput.Text;
                this.btnNext.Text = "Finish";
                this.selected_key++;
                this.populate_form_data();
                this.txtInput.Text = "";
                this.txtInput.Focus();
            }
            else if ((this.param_map.Count() - 1) == this.selected_key)
            {
                this.input_data[this.keylist[this.selected_key]] = txtInput.Text;
                this.Hide();
            }
        }

        private void frmPrompt_Load(object sender, EventArgs e)
        {
            this.populate_form_data();
            this.txtInput.Focus();
        }

        private void populate_form_data()
        {
            lblPrompt.Text = this.param_map[this.keylist[this.selected_key]];
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnNext.PerformClick();
            }
        }

        private void frmPrompt_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.WindowState = FormWindowState.Normal;
                this.Visible = false;
            }
        }            
    }
}
