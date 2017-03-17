using System;
using System.Windows.Forms;

namespace AutoScanner
{
    class Program
    {
        /// <summary>
        /// First executed code. Render a Windows.Form.Application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //TODO Application.Run(new MainForm());
        }

    }
}
