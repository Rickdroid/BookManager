﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());

            Login loGingo = new Login();
            loGingo.ShowDialog();

            //窗口跳转
            if(loGingo.DialogResult == DialogResult.OK) //判断login类的button是否确认
            {
                loGingo.Dispose(); //释放桌面资源
                Application.Run(new IndexNormal());
            }
            else if(loGingo.DialogResult == DialogResult.Cancel)
            {
                loGingo.Dispose();
                return;
            }
        }
    }
}
