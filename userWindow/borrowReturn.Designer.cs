namespace BookManager
{
    partial class borrowReturn
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
            this.winMini = new System.Windows.Forms.PictureBox();
            this.winClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Topbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winClose)).BeginInit();
            this.SuspendLayout();
            // 
            // Topbar
            // 
            this.Topbar.Location = new System.Drawing.Point(-8, -1);
            this.Topbar.Name = "Topbar";
            this.Topbar.Size = new System.Drawing.Size(1280, 30);
            this.Topbar.TabIndex = 0;
            this.Topbar.TabStop = false;
            this.Topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseDown);
            this.Topbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseMove);
            this.Topbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseUp);
            // 
            // winMini
            // 
            this.winMini.Location = new System.Drawing.Point(1196, -1);
            this.winMini.Name = "winMini";
            this.winMini.Size = new System.Drawing.Size(30, 30);
            this.winMini.TabIndex = 1;
            this.winMini.TabStop = false;
            this.winMini.Click += new System.EventHandler(this.winMini_Click);
            // 
            // winClose
            // 
            this.winClose.Location = new System.Drawing.Point(1232, -1);
            this.winClose.Name = "winClose";
            this.winClose.Size = new System.Drawing.Size(30, 30);
            this.winClose.TabIndex = 2;
            this.winClose.TabStop = false;
            this.winClose.Click += new System.EventHandler(this.winClose_Click);
            // 
            // borrowReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.winClose);
            this.Controls.Add(this.winMini);
            this.Controls.Add(this.Topbar);
            this.Name = "borrowReturn";
            this.Text = "borrowReturn";
            this.Load += new System.EventHandler(this.BorrowReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Topbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Topbar;
        private System.Windows.Forms.PictureBox winMini;
        private System.Windows.Forms.PictureBox winClose;
    }
}