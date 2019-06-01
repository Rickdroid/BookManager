namespace BookManager
{
    partial class IndexNormal
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
            this.Topbar = new System.Windows.Forms.Panel();
            this.welSetce = new System.Windows.Forms.Label();
            this.winMini = new System.Windows.Forms.PictureBox();
            this.winClose = new System.Windows.Forms.PictureBox();
            this.libraryBooks = new System.Windows.Forms.PictureBox();
            this.borrowReturn = new System.Windows.Forms.PictureBox();
            this.brStatus = new System.Windows.Forms.PictureBox();
            this.perMessage = new System.Windows.Forms.PictureBox();
            this.logOut = new System.Windows.Forms.PictureBox();
            this.settingsApp = new System.Windows.Forms.PictureBox();
            this.Topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsApp)).BeginInit();
            this.SuspendLayout();
            // 
            // Topbar
            // 
            this.Topbar.Controls.Add(this.welSetce);
            this.Topbar.Controls.Add(this.winMini);
            this.Topbar.Controls.Add(this.winClose);
            this.Topbar.Location = new System.Drawing.Point(0, 0);
            this.Topbar.Name = "Topbar";
            this.Topbar.Size = new System.Drawing.Size(784, 30);
            this.Topbar.TabIndex = 0;
            this.Topbar.Click += new System.EventHandler(this.Topbar_Click);
            this.Topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseDown);
            this.Topbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseMove);
            this.Topbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseUp);
            // 
            // welSetce
            // 
            this.welSetce.AutoSize = true;
            this.welSetce.Location = new System.Drawing.Point(3, 9);
            this.welSetce.Name = "welSetce";
            this.welSetce.Size = new System.Drawing.Size(41, 12);
            this.welSetce.TabIndex = 1;
            this.welSetce.Text = "label1";
            // 
            // winMini
            // 
            this.winMini.Location = new System.Drawing.Point(718, 0);
            this.winMini.Name = "winMini";
            this.winMini.Size = new System.Drawing.Size(30, 30);
            this.winMini.TabIndex = 1;
            this.winMini.TabStop = false;
            this.winMini.Click += new System.EventHandler(this.winMini_Click);
            // 
            // winClose
            // 
            this.winClose.Location = new System.Drawing.Point(754, 0);
            this.winClose.Name = "winClose";
            this.winClose.Size = new System.Drawing.Size(30, 30);
            this.winClose.TabIndex = 1;
            this.winClose.TabStop = false;
            this.winClose.Click += new System.EventHandler(this.winClose_Click);
            // 
            // libraryBooks
            // 
            this.libraryBooks.Location = new System.Drawing.Point(123, 109);
            this.libraryBooks.Name = "libraryBooks";
            this.libraryBooks.Size = new System.Drawing.Size(150, 150);
            this.libraryBooks.TabIndex = 2;
            this.libraryBooks.TabStop = false;
            this.libraryBooks.Click += new System.EventHandler(this.LibraryBooks_Click);
            // 
            // borrowReturn
            // 
            this.borrowReturn.Location = new System.Drawing.Point(307, 109);
            this.borrowReturn.Name = "borrowReturn";
            this.borrowReturn.Size = new System.Drawing.Size(150, 150);
            this.borrowReturn.TabIndex = 3;
            this.borrowReturn.TabStop = false;
            // 
            // brStatus
            // 
            this.brStatus.Location = new System.Drawing.Point(494, 109);
            this.brStatus.Name = "brStatus";
            this.brStatus.Size = new System.Drawing.Size(150, 150);
            this.brStatus.TabIndex = 4;
            this.brStatus.TabStop = false;
            // 
            // perMessage
            // 
            this.perMessage.Location = new System.Drawing.Point(123, 326);
            this.perMessage.Name = "perMessage";
            this.perMessage.Size = new System.Drawing.Size(150, 150);
            this.perMessage.TabIndex = 5;
            this.perMessage.TabStop = false;
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(307, 326);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(150, 150);
            this.logOut.TabIndex = 6;
            this.logOut.TabStop = false;
            // 
            // settingsApp
            // 
            this.settingsApp.Location = new System.Drawing.Point(494, 326);
            this.settingsApp.Name = "settingsApp";
            this.settingsApp.Size = new System.Drawing.Size(150, 150);
            this.settingsApp.TabIndex = 7;
            this.settingsApp.TabStop = false;
            // 
            // IndexNormal
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.settingsApp);
            this.Controls.Add(this.libraryBooks);
            this.Controls.Add(this.borrowReturn);
            this.Controls.Add(this.brStatus);
            this.Controls.Add(this.perMessage);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.Topbar);
            this.Name = "IndexNormal";
            this.Load += new System.EventHandler(this.IndexNormal_Load);
            this.Topbar.ResumeLayout(false);
            this.Topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Topbar;
        private System.Windows.Forms.PictureBox winClose;
        private System.Windows.Forms.Label welSetce;
        private System.Windows.Forms.PictureBox winMini;
        private System.Windows.Forms.PictureBox libraryBooks;
        private System.Windows.Forms.PictureBox borrowReturn;
        private System.Windows.Forms.PictureBox brStatus;
        private System.Windows.Forms.PictureBox perMessage;
        private System.Windows.Forms.PictureBox logOut;
        private System.Windows.Forms.PictureBox settingsApp;
    }
}