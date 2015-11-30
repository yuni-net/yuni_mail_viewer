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
            LoginForm login_form = new LoginForm();
            login_form.ShowDialog(main_form);
            main_form.connect_to_server(
                login_form.mail_address,
                login_form.password);
            Application.Run(main_form);
            main_form.destruct();
        }
    }
}
