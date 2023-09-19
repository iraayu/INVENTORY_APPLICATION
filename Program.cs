using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PrjIraAyuRiyanto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            splashform aSplashForm = new splashform();

            aSplashForm.ShowDialog();
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}
