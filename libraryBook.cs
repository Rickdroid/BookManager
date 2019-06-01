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
            this.FormBorderStyle = FormBorderStyle.None;

            Topbar.BackColor = Color.Gray;

            winClose.BackColor = Color.Red;
            winMini.BackColor = Color.Aqua;

            bookNum.Text = "书籍编号";
            bookIsbn.Text = "书籍ISBN";
            bookName.Text = "书籍名称";

            bookSearch.Text = "检索";
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
