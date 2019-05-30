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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;    //窗体风格

            logintex.Text = "登陆账号";
            passwdtex.Text = "登录密码";
            Logingo.Text = "登录";

            //welPicture.Image = //欢迎图片位置，规格400x300
            //welPicture.BackColor = Color.Transparent; 背景色透明

            //windowclose.Image =  //关闭按钮图标，规格30x30
            //windowclose.BackColor = Color.Transparent; 背景色透明
        }

        private void Windowclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //窗体移动

        public int topPosition; //获取Y轴坐标
        public int leftPosition; //获取X轴坐标
        public bool moveStatus = false; //移动窗口功能启动开关
        private void welPicture_MouseDown(object sender, MouseEventArgs e)
        {
            moveStatus = true;
            leftPosition = MousePosition.X;
            topPosition = MousePosition.Y;
        }

        private void WelPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if(moveStatus)
            {
                this.Left += MousePosition.X - leftPosition;
                this.Top += MousePosition.Y - topPosition;
                leftPosition = MousePosition.X;
                topPosition = MousePosition.Y;
            }
        }

        private void WelPicture_MouseUp(object sender, MouseEventArgs e)
        {
            moveStatus = false;
        }

        //登录
        private void Logingo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
            this.Close();
            /*if()
            {
                
            }
            else
            {
            
            }*/
        }
    }
}
