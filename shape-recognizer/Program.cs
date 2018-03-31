using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace shape_recognizer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Application.ThreadException += new ThreadExceptionEventHandler(ExceptionHandler);
        }

        private static void ExceptionHandler(object sender, ThreadExceptionEventArgs t)
        {
            string messageBoxText = "Error is occured";
            string caption = "Error";
            var result = MessageBox.Show(messageBoxText, caption, MessageBoxButtons.OK);
            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
