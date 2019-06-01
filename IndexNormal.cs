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
    public partial class IndexNormal : Form
    {
        public IndexNormal()
        {
            InitializeComponent();
        }

        private void IndexNormal_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            Topbar.BackColor = Color.Gray;

            winClose.BackColor = Color.Red;
            winMini.BackColor = Color.Aqua;

            //libraryBooks.Image = //欢迎图片位置，规格400x300
            //libraryBooks.BackColor = Color.Transparent; 背景色透明
            libraryBooks.BackColor = Color.Aqua;
            borrowReturn.BackColor = Color.Aqua;
            brStatus.BackColor = Color.Aqua;
            perMessage.BackColor = Color.Aqua;
            logOut.BackColor = Color.Aqua;
            settingsApp.BackColor = Color.Aqua;

            welSetce.Text = "欢迎你";
            welSetce.BackColor = Topbar.BackColor;

        }

        //窗体移动 
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

        private void Topbar_Click(object sender, EventArgs e)
        {

        }

        //头部的窗体状态按钮
        private void winMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void winClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //定义窗体按钮跳转
        private void LibraryBooks_Click(object sender, EventArgs e)
        {
            libraryBook libBook = new libraryBook();
            libBook.Show();
        }
    }
}
