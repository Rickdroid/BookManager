namespace BookManager
{
    partial class Index
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
            this.Topbar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Topbar)).BeginInit();
            this.SuspendLayout();
            // 
            // Topbar
            // 
            this.Topbar.Location = new System.Drawing.Point(-6, 0);
            this.Topbar.Name = "Topbar";
            this.Topbar.Size = new System.Drawing.Size(1280, 30);
            this.Topbar.TabIndex = 0;
            this.Topbar.TabStop = false;
            this.Topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseDown);
            this.Topbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseMove);
            this.Topbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseUp);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.Topbar);
            this.Name = "Index";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Topbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Topbar;
    }
}