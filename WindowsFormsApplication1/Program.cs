using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace soundcloud_uploader_client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] Args){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string upload_dir = "./uploads";
            if (Args.Length > 0) {
                foreach (string argument in Args){
                    string[] arg = argument.Split('=');
                    if (arg[0] == "upload-dir") {
                        upload_dir = arg[1];
                    }
                }
            }
            AppClass app = new AppClass(upload_dir);
            Application.Run();
        }
    }

    class AppClass{
        NotifyIcon notify_icon;
        frmMain mainWindow;
        ContextMenu exitmenu;
        ControlContainer container;
        string upload_dir;
        /// <summary>
        /// need to add a container such that I can locate it on the screen and display the context menu to exit on/near it
        /// </summary>

        public AppClass(string dir = "./upload")
        {
            this.container = new ControlContainer();
            this.notify_icon = new NotifyIcon(this.container);
            this.mainWindow = new frmMain(this.upload_dir);
            this.notify_icon.ContextMenu = new ContextMenu(new MenuItem[] { new MenuItem("&Exit", this.exit_program) });
            this.notify_icon.Icon = new System.Drawing.Icon("soundcloud-4part.ico");
            this.notify_icon.Text = "Soundcloud Upload Tagger";
            this.notify_icon.Visible = true;
            this.notify_icon.MouseDown += this.notify_icon_click;
        }

        public void notify_icon_click(object sender, System.EventArgs e)
        {
            MouseEventArgs mea = (MouseEventArgs)e;
            if (mea.Button == MouseButtons.Left)
            {
                if (this.mainWindow.Visible == true)
                {
                    this.mainWindow.Hide();
                }
                else
                {
                    this.mainWindow.Show();
                }
            }
        }

        private void exit_program(object sender, System.EventArgs e)
        {
            this.notify_icon.Visible = false;
            Application.Exit();
        }
    }

    class ControlContainer : IContainer{

        //i really have no idea what this does... other than it works :P
        ComponentCollection _components;

        public ControlContainer()
        {
            _components = new ComponentCollection(new IComponent[] { });
        }

        public void Add(IComponent component) { }

        public void Add(IComponent component, string Name) { }

        public void Remove(IComponent component) { }

        public ComponentCollection Components
        {
            get { return _components; }
        }

        public void Dispose()
        {
            _components = null;
        }
    }    
}
