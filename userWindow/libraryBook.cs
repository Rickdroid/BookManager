using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class libraryBook : Form
    {
        public libraryBook()
        {
            InitializeComponent();
        }

        private void LibraryBook_Load(object sender, EventArgs e)
        {
            //参照Login的备注
            this.FormBorderStyle = FormBorderStyle.None;

            Topbar.BackColor = Color.Gray;

            winClose.BackColor = Color.Red;
            winMini.BackColor = Color.Aqua;

            bookPicture.BackColor = Color.Aqua;
            //bookPicture.Image =

            //

            //顶部控件Text属性
            bookNum.Text = "书籍编号";
            bookIsbn.Text = "书籍ISBN";
            bookName.Text = "书籍名称";

            bookSearch.Text = "检索";

            //bookSearMessage内部控件Text属性
            //label显示的字符，用于告知用户此处是什么
            bookNumout.Text = "书籍编号";
            bookNameout.Text = "书籍名称";
            bookIsbnout.Text = "书籍ISBN";
            bookAuthorout.Text = "作者";
            bookCompany.Text = "出版社";
            bookDate.Text = "出版日期";
            bookOutnum.Text = "出版号";
            bookIntime.Text = "入库时间";
            bookStory.Text = "书籍内容";
            bookLanguage.Text = "书籍语种";
            booksOf.Text = "书籍数量";
            bookSubject.Text = "书籍种类";
            bookRemaining.Text = "库存量";
            
            //textbox的可用性，设置不可用仅用于显示检索的内容
            bookNumoutText.Enabled = false;
            bookNameoutText.Enabled = false;
            bookIsbnoutText.Enabled = false;
            bookAuthoroutText.Enabled = false;
            bookCompanyText.Enabled = false;
            bookDateText.Enabled = false;
            bookOutnumText.Enabled = false;
            bookIntimeText.Enabled = false;
            bookStoryText.Enabled = false;
            bookLanguageText.Enabled = false;
            booksOfText.Enabled = false;
            bookSubjectText.Enabled = false;
            bookRemainingText.Enabled = false;

        }
        //窗体移动
        private void Topbar_Click(object sender, EventArgs e)
        {

        }

        public int topPosition;
        public int leftPosition;
        public bool moveStatus = false;

        private void Topbar_MouseDown(object sender, MouseEventArgs e)
        {
            moveStatus = true;
            leftPosition = MousePosition.X;
            topPosition = MousePosition.Y;
        }

        private void Topbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveStatus)
            {
                this.Left += MousePosition.X - leftPosition;
                this.Top += MousePosition.Y - topPosition;
                leftPosition = MousePosition.X;
                topPosition = MousePosition.Y;
            }
        }

        private void Topbar_MouseUp(object sender, MouseEventArgs e)
        {
            moveStatus = false;
        }

        //头部的窗体状态按钮
        private void winClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void winMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
