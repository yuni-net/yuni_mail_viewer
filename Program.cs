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
            Form1 main_form = new Form1();
            //LoginForm login_form = new LoginForm();
            //login_form.ShowDialog(main_form);

            string mail_address = "nhs30070@nagoya.hal.ac.jp";
            string password = "d19941005";

            main_form.connect_to_server(mail_address, password);
            Application.Run(main_form);
            main_form.destruct();
        }
    }
}
