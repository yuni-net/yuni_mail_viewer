using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yuni_mail_viewer
{
    public partial class LoginForm : Form
    {
        public string mail_address { get; set; }
        public string password { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private bool isnt_it_mail_address(string text)
        {
            // todo
            return false;
        }

        private void on_click_login(object sender, EventArgs e)
        {
            if(isnt_it_mail_address(mail_address_box.Text))
            {
                MessageBox.Show("有効なメールアドレスを入力してください");
                return;
            }

            mail_address = mail_address_box.Text;
            password = password_box.Text;
            Dispose();
        }
    }
}
