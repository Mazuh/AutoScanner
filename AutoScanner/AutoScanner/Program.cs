using System;
using System.Windows.Forms;

namespace AutoScanner
{
    class Program
    {

        // root directory folder for saving scanned images
        public static readonly string DESTINATION_ROOT_DIR = @"C:\MeusArquivos_AutoScanner\";

        /// <summary>
        ///     First executed code. Render a Windows.Form.Application.
        /// </summary>
        /* The STAThreadAttribute is essentially a requirement for the Windows message pump to communicate with COM components.
         * More info: http://stackoverflow.com/questions/1361033/what-does-stathread-do */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

    }
}
