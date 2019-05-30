namespace BookManager
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Logingo = new System.Windows.Forms.Button();
            this.welPicture = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.logintex = new System.Windows.Forms.Label();
            this.passwdtex = new System.Windows.Forms.Label();
            this.windowclose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.welPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowclose)).BeginInit();
            this.SuspendLayout();
            // 
            // Logingo
            // 
            this.Logingo.Location = new System.Drawing.Point(151, 226);
            this.Logingo.Name = "Logingo";
            this.Logingo.Size = new System.Drawing.Size(75, 23);
            this.Logingo.TabIndex = 0;
            this.Logingo.Text = "button1";
            this.Logingo.UseVisualStyleBackColor = true;
            this.Logingo.Click += new System.EventHandler(this.Logingo_Click);
            // 
            // welPicture
            // 
            this.welPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.welPicture.Location = new System.Drawing.Point(-8, -3);
            this.welPicture.Name = "welPicture";
            this.welPicture.Size = new System.Drawing.Size(400, 150);
            this.welPicture.TabIndex = 1;
            this.welPicture.TabStop = false;
            this.welPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.welPicture_MouseDown);
            this.welPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WelPicture_MouseMove);
            this.welPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WelPicture_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 3;
            // 
            // logintex
            // 
            this.logintex.AutoSize = true;
            this.logintex.Location = new System.Drawing.Point(105, 156);
            this.logintex.Name = "logintex";
            this.logintex.Size = new System.Drawing.Size(41, 12);
            this.logintex.TabIndex = 4;
            this.logintex.Text = "label1";
            // 
            // passwdtex
            // 
            this.passwdtex.AutoSize = true;
            this.passwdtex.Location = new System.Drawing.Point(105, 189);
            this.passwdtex.Name = "passwdtex";
            this.passwdtex.Size = new System.Drawing.Size(41, 12);
            this.passwdtex.TabIndex = 5;
            this.passwdtex.Text = "label2";
            // 
            // windowclose
            // 
            this.windowclose.BackColor = System.Drawing.Color.Red;
            this.windowclose.Location = new System.Drawing.Point(351, 226);
            this.windowclose.Name = "windowclose";
            this.windowclose.Size = new System.Drawing.Size(30, 30);
            this.windowclose.TabIndex = 6;
            this.windowclose.TabStop = false;
            this.windowclose.Click += new System.EventHandler(this.Windowclose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.windowclose);
            this.Controls.Add(this.passwdtex);
            this.Controls.Add(this.logintex);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.welPicture);
            this.Controls.Add(this.Logingo);
            this.Name = "Login";
            this.Text = "后台登录";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.welPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logingo;
        private System.Windows.Forms.PictureBox welPicture;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label logintex;
        private System.Windows.Forms.Label passwdtex;
        private System.Windows.Forms.PictureBox windowclose;
    }
}

