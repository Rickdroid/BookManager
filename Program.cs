using System;
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

            if(loGingo.DialogResult == DialogResult.OK)
            {
                loGingo.Dispose();
                Application.Run(new Index());
            }
            else if(loGingo.DialogResult == DialogResult.Cancel)
            {
                loGingo.Dispose();
                return;
            }
        }
    }
}
