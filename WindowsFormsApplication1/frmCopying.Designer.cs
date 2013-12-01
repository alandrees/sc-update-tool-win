namespace soundcloud_uploader_client
{
    partial class frmCopying
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrContinuing = new System.Windows.Forms.Timer(this.components);
            this.lblCopying = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrContinuing
            // 
            this.tmrContinuing.Enabled = true;
            this.tmrContinuing.Interval = 600;
            this.tmrContinuing.Tick += new System.EventHandler(this.tmrContinuing_Tick);
            // 
            // lblCopying
            // 
            this.lblCopying.AutoSize = true;
            this.lblCopying.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopying.Location = new System.Drawing.Point(12, 32);
            this.lblCopying.Name = "lblCopying";
            this.lblCopying.Size = new System.Drawing.Size(85, 25);
            this.lblCopying.TabIndex = 0;
            this.lblCopying.Text = "Copying";
            // 
            // frmCopying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 83);
            this.Controls.Add(this.lblCopying);
            this.Name = "frmCopying";
            this.Text = "Copying";
            this.Load += new System.EventHandler(this.frmCopying_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrContinuing;
        private System.Windows.Forms.Label lblCopying;
    }
}