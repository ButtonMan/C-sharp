using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingFormeSize
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MyForme wnd = new MyForme();
            wnd.Text = "Using Form Method \"Size:\"";

            Application.Run(wnd);
        }
    }
}
