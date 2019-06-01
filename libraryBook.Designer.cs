namespace BookManager
{
    partial class libraryBook
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
            this.winClose = new System.Windows.Forms.PictureBox();
            this.winMini = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookNum = new System.Windows.Forms.Label();
            this.bookNumin = new System.Windows.Forms.TextBox();
            this.bookIsbn = new System.Windows.Forms.Label();
            this.bookIsbnin = new System.Windows.Forms.TextBox();
            this.bookName = new System.Windows.Forms.Label();
            this.bookNamein = new System.Windows.Forms.TextBox();
            this.bookSearch = new System.Windows.Forms.Button();
            this.bookNumout = new System.Windows.Forms.Label();
            this.bookSearMessage = new System.Windows.Forms.Panel();
            this.bookNumoutText = new System.Windows.Forms.TextBox();
            this.bookNameout = new System.Windows.Forms.Label();
            this.bookNameoutText = new System.Windows.Forms.TextBox();
            this.bookIsbnout = new System.Windows.Forms.Label();
            this.bookIsbnoutText = new System.Windows.Forms.TextBox();
            this.bookAuthorout = new System.Windows.Forms.Label();
            this.bookAuthoroutText = new System.Windows.Forms.TextBox();
            this.bookCompany = new System.Windows.Forms.Label();
            this.bookCompanyText = new System.Windows.Forms.TextBox();
            this.bookDate = new System.Windows.Forms.Label();
            this.bookOutnum = new System.Windows.Forms.Label();
            this.bookIntime = new System.Windows.Forms.Label();
            this.bookDateText = new System.Windows.Forms.TextBox();
            this.bookOutnumText = new System.Windows.Forms.TextBox();
            this.bookStoryText = new System.Windows.Forms.RichTextBox();
            this.bookIntimeText = new System.Windows.Forms.TextBox();
            this.bookStory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Topbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.bookSearMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Topbar
            // 
            this.Topbar.Location = new System.Drawing.Point(-8, -1);
            this.Topbar.Name = "Topbar";
            this.Topbar.Size = new System.Drawing.Size(1280, 30);
            this.Topbar.TabIndex = 0;
            this.Topbar.TabStop = false;
            this.Topbar.Click += new System.EventHandler(this.Topbar_Click);
            this.Topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseDown);
            this.Topbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseMove);
            this.Topbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseUp);
            // 
            // winClose
            // 
            this.winClose.Location = new System.Drawing.Point(1232, -1);
            this.winClose.Name = "winClose";
            this.winClose.Size = new System.Drawing.Size(30, 30);
            this.winClose.TabIndex = 1;
            this.winClose.TabStop = false;
            this.winClose.Click += new System.EventHandler(this.winClose_Click);
            // 
            // winMini
            // 
            this.winMini.Location = new System.Drawing.Point(1196, -1);
            this.winMini.Name = "winMini";
            this.winMini.Size = new System.Drawing.Size(30, 30);
            this.winMini.TabIndex = 2;
            this.winMini.TabStop = false;
            this.winMini.Click += new System.EventHandler(this.winMini_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 525);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1240, 224);
            this.dataGridView1.TabIndex = 3;
            // 
            // bookNum
            // 
            this.bookNum.AutoSize = true;
            this.bookNum.Location = new System.Drawing.Point(80, 40);
            this.bookNum.Name = "bookNum";
            this.bookNum.Size = new System.Drawing.Size(41, 12);
            this.bookNum.TabIndex = 4;
            this.bookNum.Text = "label1";
            // 
            // bookNumin
            // 
            this.bookNumin.Location = new System.Drawing.Point(139, 37);
            this.bookNumin.Name = "bookNumin";
            this.bookNumin.Size = new System.Drawing.Size(177, 21);
            this.bookNumin.TabIndex = 5;
            // 
            // bookIsbn
            // 
            this.bookIsbn.AutoSize = true;
            this.bookIsbn.Location = new System.Drawing.Point(413, 40);
            this.bookIsbn.Name = "bookIsbn";
            this.bookIsbn.Size = new System.Drawing.Size(41, 12);
            this.bookIsbn.TabIndex = 6;
            this.bookIsbn.Text = "label2";
            // 
            // bookIsbnin
            // 
            this.bookIsbnin.Location = new System.Drawing.Point(472, 37);
            this.bookIsbnin.Name = "bookIsbnin";
            this.bookIsbnin.Size = new System.Drawing.Size(177, 21);
            this.bookIsbnin.TabIndex = 7;
            // 
            // bookName
            // 
            this.bookName.AutoSize = true;
            this.bookName.Location = new System.Drawing.Point(749, 40);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(41, 12);
            this.bookName.TabIndex = 8;
            this.bookName.Text = "label3";
            // 
            // bookNamein
            // 
            this.bookNamein.Location = new System.Drawing.Point(808, 37);
            this.bookNamein.Name = "bookNamein";
            this.bookNamein.Size = new System.Drawing.Size(177, 21);
            this.bookNamein.TabIndex = 9;
            // 
            // bookSearch
            // 
            this.bookSearch.Location = new System.Drawing.Point(1101, 35);
            this.bookSearch.Name = "bookSearch";
            this.bookSearch.Size = new System.Drawing.Size(75, 23);
            this.bookSearch.TabIndex = 10;
            this.bookSearch.Text = "button1";
            this.bookSearch.UseVisualStyleBackColor = true;
            // 
            // bookNumout
            // 
            this.bookNumout.AutoSize = true;
            this.bookNumout.Location = new System.Drawing.Point(11, 33);
            this.bookNumout.Name = "bookNumout";
            this.bookNumout.Size = new System.Drawing.Size(41, 12);
            this.bookNumout.TabIndex = 11;
            this.bookNumout.Text = "label1";
            // 
            // bookSearMessage
            // 
            this.bookSearMessage.Controls.Add(this.bookStory);
            this.bookSearMessage.Controls.Add(this.bookIntimeText);
            this.bookSearMessage.Controls.Add(this.bookStoryText);
            this.bookSearMessage.Controls.Add(this.bookOutnumText);
            this.bookSearMessage.Controls.Add(this.bookDateText);
            this.bookSearMessage.Controls.Add(this.bookIntime);
            this.bookSearMessage.Controls.Add(this.bookOutnum);
            this.bookSearMessage.Controls.Add(this.bookDate);
            this.bookSearMessage.Controls.Add(this.bookCompanyText);
            this.bookSearMessage.Controls.Add(this.bookCompany);
            this.bookSearMessage.Controls.Add(this.bookAuthoroutText);
            this.bookSearMessage.Controls.Add(this.bookAuthorout);
            this.bookSearMessage.Controls.Add(this.bookIsbnoutText);
            this.bookSearMessage.Controls.Add(this.bookIsbnout);
            this.bookSearMessage.Controls.Add(this.bookNameoutText);
            this.bookSearMessage.Controls.Add(this.bookNameout);
            this.bookSearMessage.Controls.Add(this.bookNumoutText);
            this.bookSearMessage.Controls.Add(this.bookNumout);
            this.bookSearMessage.Location = new System.Drawing.Point(12, 64);
            this.bookSearMessage.Name = "bookSearMessage";
            this.bookSearMessage.Size = new System.Drawing.Size(1240, 446);
            this.bookSearMessage.TabIndex = 12;
            // 
            // bookNumoutText
            // 
            this.bookNumoutText.Location = new System.Drawing.Point(70, 30);
            this.bookNumoutText.Name = "bookNumoutText";
            this.bookNumoutText.Size = new System.Drawing.Size(177, 21);
            this.bookNumoutText.TabIndex = 12;
            // 
            // bookNameout
            // 
            this.bookNameout.AutoSize = true;
            this.bookNameout.Location = new System.Drawing.Point(11, 82);
            this.bookNameout.Name = "bookNameout";
            this.bookNameout.Size = new System.Drawing.Size(41, 12);
            this.bookNameout.TabIndex = 13;
            this.bookNameout.Text = "label2";
            // 
            // bookNameoutText
            // 
            this.bookNameoutText.Location = new System.Drawing.Point(70, 79);
            this.bookNameoutText.Name = "bookNameoutText";
            this.bookNameoutText.Size = new System.Drawing.Size(177, 21);
            this.bookNameoutText.TabIndex = 14;
            // 
            // bookIsbnout
            // 
            this.bookIsbnout.AutoSize = true;
            this.bookIsbnout.Location = new System.Drawing.Point(11, 132);
            this.bookIsbnout.Name = "bookIsbnout";
            this.bookIsbnout.Size = new System.Drawing.Size(41, 12);
            this.bookIsbnout.TabIndex = 15;
            this.bookIsbnout.Text = "label3";
            // 
            // bookIsbnoutText
            // 
            this.bookIsbnoutText.Location = new System.Drawing.Point(70, 129);
            this.bookIsbnoutText.Name = "bookIsbnoutText";
            this.bookIsbnoutText.Size = new System.Drawing.Size(177, 21);
            this.bookIsbnoutText.TabIndex = 16;
            // 
            // bookAuthorout
            // 
            this.bookAuthorout.AutoSize = true;
            this.bookAuthorout.Location = new System.Drawing.Point(11, 181);
            this.bookAuthorout.Name = "bookAuthorout";
            this.bookAuthorout.Size = new System.Drawing.Size(41, 12);
            this.bookAuthorout.TabIndex = 17;
            this.bookAuthorout.Text = "label4";
            // 
            // bookAuthoroutText
            // 
            this.bookAuthoroutText.Location = new System.Drawing.Point(70, 178);
            this.bookAuthoroutText.Name = "bookAuthoroutText";
            this.bookAuthoroutText.Size = new System.Drawing.Size(177, 21);
            this.bookAuthoroutText.TabIndex = 18;
            // 
            // bookCompany
            // 
            this.bookCompany.AutoSize = true;
            this.bookCompany.Location = new System.Drawing.Point(314, 33);
            this.bookCompany.Name = "bookCompany";
            this.bookCompany.Size = new System.Drawing.Size(41, 12);
            this.bookCompany.TabIndex = 19;
            this.bookCompany.Text = "label5";
            // 
            // bookCompanyText
            // 
            this.bookCompanyText.Location = new System.Drawing.Point(373, 30);
            this.bookCompanyText.Name = "bookCompanyText";
            this.bookCompanyText.Size = new System.Drawing.Size(177, 21);
            this.bookCompanyText.TabIndex = 20;
            // 
            // bookDate
            // 
            this.bookDate.AutoSize = true;
            this.bookDate.Location = new System.Drawing.Point(314, 82);
            this.bookDate.Name = "bookDate";
            this.bookDate.Size = new System.Drawing.Size(41, 12);
            this.bookDate.TabIndex = 21;
            this.bookDate.Text = "label6";
            // 
            // bookOutnum
            // 
            this.bookOutnum.AutoSize = true;
            this.bookOutnum.Location = new System.Drawing.Point(314, 132);
            this.bookOutnum.Name = "bookOutnum";
            this.bookOutnum.Size = new System.Drawing.Size(41, 12);
            this.bookOutnum.TabIndex = 22;
            this.bookOutnum.Text = "label7";
            // 
            // bookIntime
            // 
            this.bookIntime.AutoSize = true;
            this.bookIntime.Location = new System.Drawing.Point(314, 181);
            this.bookIntime.Name = "bookIntime";
            this.bookIntime.Size = new System.Drawing.Size(41, 12);
            this.bookIntime.TabIndex = 23;
            this.bookIntime.Text = "label8";
            // 
            // bookDateText
            // 
            this.bookDateText.Location = new System.Drawing.Point(373, 79);
            this.bookDateText.Name = "bookDateText";
            this.bookDateText.Size = new System.Drawing.Size(177, 21);
            this.bookDateText.TabIndex = 24;
            // 
            // bookOutnumText
            // 
            this.bookOutnumText.Location = new System.Drawing.Point(373, 129);
            this.bookOutnumText.Name = "bookOutnumText";
            this.bookOutnumText.Size = new System.Drawing.Size(177, 21);
            this.bookOutnumText.TabIndex = 25;
            // 
            // bookStoryText
            // 
            this.bookStoryText.Location = new System.Drawing.Point(70, 229);
            this.bookStoryText.Name = "bookStoryText";
            this.bookStoryText.Size = new System.Drawing.Size(298, 138);
            this.bookStoryText.TabIndex = 26;
            this.bookStoryText.Text = "";
            // 
            // bookIntimeText
            // 
            this.bookIntimeText.Location = new System.Drawing.Point(373, 178);
            this.bookIntimeText.Name = "bookIntimeText";
            this.bookIntimeText.Size = new System.Drawing.Size(177, 21);
            this.bookIntimeText.TabIndex = 27;
            // 
            // bookStory
            // 
            this.bookStory.AutoSize = true;
            this.bookStory.Location = new System.Drawing.Point(11, 232);
            this.bookStory.Name = "bookStory";
            this.bookStory.Size = new System.Drawing.Size(41, 12);
            this.bookStory.TabIndex = 28;
            this.bookStory.Text = "label9";
            // 
            // libraryBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.bookSearMessage);
            this.Controls.Add(this.bookSearch);
            this.Controls.Add(this.bookNamein);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.bookIsbnin);
            this.Controls.Add(this.bookIsbn);
            this.Controls.Add(this.bookNumin);
            this.Controls.Add(this.bookNum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.winMini);
            this.Controls.Add(this.winClose);
            this.Controls.Add(this.Topbar);
            this.Name = "libraryBook";
            this.Text = "libraryBook";
            this.Load += new System.EventHandler(this.LibraryBook_Load);
            this.Click += new System.EventHandler(this.winMini_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Topbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.bookSearMessage.ResumeLayout(false);
            this.bookSearMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Topbar;
        private System.Windows.Forms.PictureBox winClose;
        private System.Windows.Forms.PictureBox winMini;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label bookNum;
        private System.Windows.Forms.TextBox bookNumin;
        private System.Windows.Forms.Label bookIsbn;
        private System.Windows.Forms.TextBox bookIsbnin;
        private System.Windows.Forms.Label bookName;
        private System.Windows.Forms.TextBox bookNamein;
        private System.Windows.Forms.Button bookSearch;
        private System.Windows.Forms.Label bookNumout;
        private System.Windows.Forms.Panel bookSearMessage;
        private System.Windows.Forms.TextBox bookCompanyText;
        private System.Windows.Forms.Label bookCompany;
        private System.Windows.Forms.TextBox bookAuthoroutText;
        private System.Windows.Forms.Label bookAuthorout;
        private System.Windows.Forms.TextBox bookIsbnoutText;
        private System.Windows.Forms.Label bookIsbnout;
        private System.Windows.Forms.TextBox bookNameoutText;
        private System.Windows.Forms.Label bookNameout;
        private System.Windows.Forms.TextBox bookNumoutText;
        private System.Windows.Forms.Label bookStory;
        private System.Windows.Forms.TextBox bookIntimeText;
        private System.Windows.Forms.RichTextBox bookStoryText;
        private System.Windows.Forms.TextBox bookOutnumText;
        private System.Windows.Forms.TextBox bookDateText;
        private System.Windows.Forms.Label bookIntime;
        private System.Windows.Forms.Label bookOutnum;
        private System.Windows.Forms.Label bookDate;
    }
}