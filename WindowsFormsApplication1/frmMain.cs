using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace soundcloud_uploader_client
{


    public partial class frmMain : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        private string soundcloud_directory;

        bool disable_dragging = false;

        private Dictionary<String, String> file_data = new Dictionary<String, String>();

        public frmMain(string upload_dir)
        {
            InitializeComponent();
            this.soundcloud_directory = upload_dir;
        }
 
        private void frmMain_Load(object sender, EventArgs e){

            if (!Directory.Exists(this.soundcloud_directory)) {
                System.IO.Directory.CreateDirectory(this.soundcloud_directory);
            }
         
            this.Visible = false;
        }

        protected override CreateParams CreateParams {
            get {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void do_data_input(object sender, DragEventArgs e)
        {
            if (!this.disable_dragging)
            {
                this.disable_dragging = true;
                string new_filename = "";
                string[] data = (string[])e.Data.GetData(DataFormats.FileDrop, false);

                foreach (string file_name in data)
                {
                    MessageBox.Show(file_name);
                    FileInfo info = new FileInfo(file_name);
                    FileAttributes fa = File.GetAttributes(file_name);

                    if (!Directory.Exists(file_name)) {
                        frmPrompt prompt = new frmPrompt(info.Name);
                        frmCopying cpdialog = new frmCopying();

                        prompt.ShowDialog();

                        this.file_data = prompt.input_data;

                        if ((this.file_data["title"] != "") &&
                             (this.file_data["genre"] != "")) {
                            new_filename = this.file_data["title"] + " ~- " +
                                           this.file_data["genre"] + " ~- " +
                                           this.file_data["sc_tags"] + " ~- " +
                                           this.file_data["mtags"] + ".wav";
                            /*this.file_data["mtags"] + " ~- " +
                             this.file_data["dls"] + " ~- " +
                             this.file_data["private"] + ".wav";*/

                            cpdialog._show();
                            this.disable_dragging = true;
                            if (this.copy_file_to_sc_dir(file_name, new_filename) == false) {
                                MessageBox.Show("Unable to copy " + file_name);
                            }

                            cpdialog._hide();
                        }
                    }
                }

                this.disable_dragging = false;
            }
        }
        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && !this.disable_dragging)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private bool copy_file_to_sc_dir(string file_name, string new_filename)
        {
            string destfile = System.IO.Path.Combine(this.soundcloud_directory, new_filename);

            try
            {
                System.IO.File.Copy(file_name, destfile);
            }

            catch (System.IO.IOException e) { e.ToString(); }


            return File.Exists(destfile);
        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Resize(object sender, EventArgs e) {
            if (FormWindowState.Minimized == this.WindowState) {
                this.WindowState = FormWindowState.Normal;
                this.Visible = false;
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.WindowState = FormWindowState.Normal;
                this.Visible = false;
            }
        }
    }
}
