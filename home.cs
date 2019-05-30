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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            topbar.BackColor = Color.Gray;
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
    }
}
