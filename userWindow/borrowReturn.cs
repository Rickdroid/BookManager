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
    public partial class borrowReturn : Form
    {
        public borrowReturn()
        {
            InitializeComponent();
        }

        private void BorrowReturn_Load(object sender, EventArgs e)
        {
            //参照Login的备注
            this.FormBorderStyle = FormBorderStyle.None;

            Topbar.BackColor = Color.Gray;

            winClose.BackColor = Color.Red;
            winMini.BackColor = Color.Aqua;
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

        //头部的窗体状态按钮
        private void winMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void winClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
