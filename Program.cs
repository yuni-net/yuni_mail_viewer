using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yuni_mail_viewer
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

            //Form1 main_form = new Form1();
            //Application.Run(main_form);
            //LoginForm login = new LoginForm();
            //login.ShowDialog(main_form);
        }
    }
}
