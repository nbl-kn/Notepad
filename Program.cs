using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    static class Program
    {
        static bool isClosed = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); //Runs the form.
            //var form = new MainForm();
            //form.Show();

            //form.FormClosed += Form_FormClosed;
            //while (!isClosed)
            //{
            //    Application.DoEvents();
            //    Thread.Sleep(100);
            //}
        }

        //private static void Form_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    Application.ExitThread();
        //    isClosed = true;
        //}
    }
}
